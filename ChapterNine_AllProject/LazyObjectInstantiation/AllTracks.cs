using System;

namespace LazyObjectInstantiation
{
    class AllTracks
    {
        private Song[] _allSongs = new Song[10_000];
        
        public AllTracks() 
        {
            Console.WriteLine("Filling up the songs!");
        }
    }
}