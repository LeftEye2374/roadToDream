package com.example.bootConfigDemo;

import lombok.RequiredArgsConstructor;
import org.springframework.boot.context.event.ApplicationReadyEvent;
import org.springframework.context.event.EventListener;

import java.util.UUID;

@RequiredArgsConstructor
public class EventQueueWorker {

    private final EventQueue eventQueue;

    @EventListener(ApplicationReadyEvent.class)
    public void startEventQueue(){
        startEventProducer();
        startEventConsumer();
    }

    private void startEventConsumer() {
        Thread eventProducerThread = new Thread(() -> {
            while(true){
                try {
                UUID id = UUID.randomUUID();
                Event event = Event.builder()
                        .id(id)
                        .payload("payload for event + " + id)
                        .build();
                eventQueue.enqueue(event);

                Thread.sleep(3000);
            }catch (InterruptedException e){
                    Thread.currentThread().interrupt();
                }
            }
        });
        eventProducerThread.start();
    }

    private void startEventProducer() {
        Thread eventConsumerThread = new Thread(() -> {
            while(true){
                Event event = eventQueue.deQueue();
                System.out.println(event);
            }
        });
        eventConsumerThread.start();
    }
}
