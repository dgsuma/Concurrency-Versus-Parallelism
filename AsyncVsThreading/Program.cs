using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncVsThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Code 1");
            Console.WriteLine("Code 2 " + Thread.CurrentThread.ManagedThreadId);
            SomeMethoD();
            Console.WriteLine("Code 7");
            Console.WriteLine("Code 8");
            Console.Read();

        }

        static async void SomeMethoD()
        {
            Console.WriteLine("Code 3");
            Console.WriteLine("Code 4");

            await Task.Delay(20000); // 20 seconds of delay
            Console.WriteLine("Code 5");
            Console.WriteLine("Code 6 " + Thread.CurrentThread.ManagedThreadId);
        }

        /*
        static void Main(string[] args)
        {
            Thread x = new Thread(SomeMethoD);
            x.Start();
            //SomeMethoD();
            Console.WriteLine("Main method code");
            Console.Read();
        }

        static void SomeMethoD()
        {
            Task.Delay(60000).Wait();
            Console.WriteLine("Async code finishes");
        }

        static async void SomeMethoD()
        {
            await Task.Delay(60000); // 60 seconds of delay
            Console.WriteLine("Async code finishes");
        }
        */
    }
}
