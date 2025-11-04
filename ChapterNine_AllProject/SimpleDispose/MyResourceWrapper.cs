using System;

namespace SimpleDispose
{
    class MyResourceWrapper : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("In dispose");
        }

        public static void UsingDeclaration()
        {
            using var rw = new MyResourceWrapper();
            Console.WriteLine("About to Dispose");
        }
    }
}