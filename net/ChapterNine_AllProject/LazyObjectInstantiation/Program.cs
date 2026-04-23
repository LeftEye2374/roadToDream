using System;
using LazyObjectInstantiation;

Console.WriteLine("Fun With Lazy  Instantiation");

MediaPlayer mediaPlayer = new MediaPlayer();
mediaPlayer.Play();

MediaPlayer yourMediadPlayer = new MediaPlayer();
AllTracks yourMusic = yourMediadPlayer.GetAllTracks();
Console.ReadLine();