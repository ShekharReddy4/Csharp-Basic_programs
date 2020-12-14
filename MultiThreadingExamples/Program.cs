using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingExamples
{
    class Program
    {
        public static void CallToChildThread()
        {
            Console.WriteLine("Child thread starts");

            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("i value is : {0}", i);
                i++;
            }
        }

        public static void CallToChildThread_AbortEx()
        {
            try
            {
                Console.WriteLine("Child thread2 starts");

                // do some work, like counting to 10
                for (int counter = 0; counter <= 10; counter++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine(counter);
                }

                Console.WriteLine("Child Thread2 Completed");
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine("Thread2 Abort Exception");
            }
            finally
            {
                Console.WriteLine("Couldn't catch the Thread2 Exception");
            }
        }
        static void Main(string[] args)
        {
            Thread th = Thread.CurrentThread;
            th.Name = "MainThread";

            //Some properties frequently used on the Thread class

            Console.WriteLine("This is {0}", th.Name);
            Console.WriteLine("CurrentContext is {0}", Thread.CurrentContext);
            Console.WriteLine("IsThreadPoolThread is {0}", th.IsThreadPoolThread);
            Console.WriteLine("CurrentCulture is {0}", th.CurrentCulture);
            //Console.WriteLine("This is {0}", Thread.CurrentPrinciple);
            Console.WriteLine("CurrentThread is {0}", Thread.CurrentThread);
            Console.WriteLine("CurrentUICulture is {0}", th.CurrentUICulture);
            Console.WriteLine("ExecutionContext is {0}", th.ExecutionContext);
            Console.WriteLine("IsAlive is {0}", th.IsAlive);
            Console.WriteLine("IsBackground is {0}", th.IsBackground);
            Console.WriteLine("Priority is {0}", th.Priority);
            Console.WriteLine("ThreadState is {0}", th.ThreadState);

            // Creating a Child thread and starting it using the Start() method on the thread isntance
            ThreadStart childref = new ThreadStart(CallToChildThread);
            Console.WriteLine("In Main: Creating the Child thread");
            Thread childThread = new Thread(childref);

            childThread.Start();
            Console.WriteLine("Main thread");
            Console.WriteLine("Main thread");
            Console.WriteLine("Main thread");
            Thread.Sleep(5);
            Console.WriteLine("Main thread");
            Console.WriteLine("Main thread");
            Console.WriteLine("Main thread");
            Console.WriteLine("Main thread");


            // Example of usage of abort fucntion

            ThreadStart childref2 = new ThreadStart(CallToChildThread_AbortEx);
            Console.WriteLine("In Main: Creating the Child thread2");

            Thread childThread2 = new Thread(childref2);
            childThread2.Start();

            //stop the main thread for some time
            Thread.Sleep(2000);

            //now abort the child
            Console.WriteLine("In Main: Aborting the Child thread2");

            childThread2.Abort();
        }
    }
}
