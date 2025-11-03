using System;

namespace SimpleFinalizer
{
    class MyResourceWrapper
    {
        ~MyResourceWrapper() => Console.Beep();
    }
}