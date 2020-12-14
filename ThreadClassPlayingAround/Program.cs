using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadClassPlayingAround
{
    class Program
    {
        static void Main(string[] args)
        {
            Number n1 = new Number();
            Thread t = new Thread(n1.PrintNumbers);
            // In the above line --- here we are not passing the delegate though the constructor requires a delgate
            // framework automatically creates a delegate and pass the param func to that delegate
            t.Start();

            Number n2 = new Number();
            Thread t2 = new Thread(new ThreadStart(n2.PrintNumbers));
            t2.Start();

            Number n3 = new Number();
            Thread t3 = new Thread(delegate() { n3.PrintNumbers(); });
            t3.Start();

            Number n4 = new Number();
            Thread t4 = new Thread(delegate () { n4.PrintNumbers(); });
            t4.Start();

            Number n5 = new Number();
            Thread t5 = new Thread(() => { Number.SPrintNumbers(); Console.WriteLine("kasjdkasn"); });
            t5.Start();


        }
    }
    class Number
    {
        public static void SPrintNumbers()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1);
            }
        }
        public  void PrintNumbers()
        {
            for(int i =0;i<10;i++)
            {
                Console.WriteLine(i+1);
            }
        }

        public void PrintNumbers2(int target)
        {
            for (int i = 0; i < target; i++)
            {
                Console.WriteLine(i + 1);
            }
        }
    }
}
