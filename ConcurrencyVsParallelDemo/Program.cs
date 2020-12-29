using System;
using System.Threading.Tasks;

namespace ConcurrencyVsParallelDemo
{
    class Program
    {
        /* Below 3 tasks run concurrently */
        /// <summary>
        /// Concurrency means executing multiple task on the same core in a non-blocking
        /// manner. Concurrency uses the same core & time slicing. It switches the time alots between task context, 
        /// to offer the time to finished the each defined task. Concurrency is a feel of Parallelism
        /// while Parallelism is the real Parallelism. Concurrency uses for usable, non-blocking
        /// and your application should not hang.
        /// Concurrency is a non-blocking light weight machinism and it achieves purely
        /// through Software Design
        /// </summary>
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
        /// <summary>
        /// Parallelism means executing multiple task on multiple cores.
        /// Parallelism uses different CPU cores (different threads) or in a totally different core of a 
        /// seperate machine to run the each of defined task. When use Parallelism, each task should 
        /// run on its own without chatting with another perallely runing task, hence it boost the perfomance 
        /// and also its heavy weight to the machine.
        /// Parallelism is totally Performance based hardware phenomenon.
        /// </summary>
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
