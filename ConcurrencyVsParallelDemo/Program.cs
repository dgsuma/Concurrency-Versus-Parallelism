using System;
using System.Threading.Tasks;

namespace ConcurrencyVsParallelDemo
{
    class Program
    {
        /* Below 3 tasks run concurrently */
        static void Main(string[] args)
        {
            NewMethod1();

            NewMethod2();

            Console.WriteLine("Start data input , enter your name");
            string str = Console.ReadLine();
            Console.WriteLine(str);
            Console.ReadLine();
        }


        private static async void NewMethod1()
        {
            await Task.Delay(20000); // downloading file 1, 20 sec delay
            Console.WriteLine("Downloaded file 1");
        }

        private static async void NewMethod2()
        {
            await Task.Delay(20000);
            Console.WriteLine("Downloaded file 2"); // downloading file 2. 20 sec delay
        }


        /* Below 3 tasks run parallely */
        /*
        static void Main(string[] args)
        {
            Task.Factory.StartNew(NewMethod1);

            Task.Factory.StartNew(NewMethod2);

            Console.WriteLine("Start data input , enter your name");
            string str = Console.ReadLine();
            Console.WriteLine(str);
            Console.ReadLine();
        }


        private static  void NewMethod1()
        {
            Task.Delay(10000); // downloading file 1, 10 sec delay
            Console.WriteLine("Downloaded file 1");
        }

        private static void NewMethod2()
        {
            Task.Delay(10000);
            Console.WriteLine("Downloaded file 2"); // downloading file 2, 10 sec delay
        }
        */
    }
}
