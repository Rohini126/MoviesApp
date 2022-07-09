using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Threading;

namespace MovieServices
{
    class Program
    {
        private static void Main()
        {
            try
            {
               // Prevents this host process from terminating so services keeps running. 
                Thread.Sleep(Timeout.Infinite);
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
