using System;

namespace LazyObjectInstantiation
{
    class MediaPlayer
    {
        public void Play() { }
        public void Pause() { }
        public void Stop() { }
        private AllTracks _allSongs = new AllTracks();


        private AllTracks GetAllTracks() 
        {
            return _allSongs;
        }
    }
}