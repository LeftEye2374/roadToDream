using System;

namespace SimpleDispose
{
    class MyResourceWrapper : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("In dispose");
        }
    }
}