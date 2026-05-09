package com.example.bootConfigDemo.config;

import com.example.bootConfigDemo.EventQueue;
import com.example.bootConfigDemo.EventQueueWorker;
import org.springframework.context.annotation.Configuration;

@Configuration
public class EventQueueConfiguration {

    public EventQueueWorker eventQueueWorker(EventQueue eventQueue){
        return new EventQueueWorker(eventQueue);
    }
}
