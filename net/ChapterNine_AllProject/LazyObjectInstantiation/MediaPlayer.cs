using System;

namespace LazyObjectInstantiation
{
    class MediaPlayer
    {
        public void Play() { }
        public void Pause() { }
        public void Stop() { }
        private Lazy<AllTracks> _allSongs = new Lazy<AllTracks>();


        public AllTracks GetAllTracks() 
        {
            return _allSongs.Value;
        }
    }
}