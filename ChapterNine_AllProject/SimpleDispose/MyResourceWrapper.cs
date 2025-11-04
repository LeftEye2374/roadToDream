using System;

namespace SimpleDispose
{
    class MyResourceWrapper : IDisposable
    {
        private bool disposed = false;

        public void Dispose()
        {
            CleanUp(true);
            GC.SuppressFinalize(this);
        }

        private void CleanUp(bool disposing)
        {
            if (!this.disposed) 
            {
                if (disposing)
                {
                    // освободить управляемые ресурсы
                }
                // отчистить неуправляемые ресурсы
            }
            disposed = true;
        }

        ~MyResourceWrapper() 
        {
            CleanUp(false);
        }
    }
}