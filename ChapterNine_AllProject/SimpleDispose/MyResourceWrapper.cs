using System;

namespace SimpleDispose
{
    class MyResourceWrapper : IDisposable
    {
        ~MyResourceWrapper()
        {

        }

        public void Dispose() 
        {
            GC.SuppressFinalize(this);        
        }
    }
}