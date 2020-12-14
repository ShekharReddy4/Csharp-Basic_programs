using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// This program demos multicasting using the delegate(i.e., calling the delegate once will call all the functions as they added respectively to the delegate)
/// </summary>
/// 
/// <summary>
/// Delegate is a type safe fucntion pointer
/// 
/// </summary>
namespace Delegate
{
    delegate int NumberChanger(int n);
    class TestDelegate
    {
        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            Console.WriteLine("in AddNum Class");
            getNum();
            return num;
        }
        public static int MultNum(int q)
        {
            num *= q;
            Console.WriteLine("in MultNum Class");
            getNum();
            return num;
        }
        public static void getNum()
        {
            Console.WriteLine("Value of Num: {0}", num);
        }
        static void Main(string[] args)
        {
            //create delegate instances
            NumberChanger nc;
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);

            nc = nc1;
            nc += nc2;

            //calling multicast  - means we are calling the two functions which are bind to the delegate at a time but the execution happens as they are bind

            nc(5);

            // Using a special delegate Func reference and pointing it to an anonymous function created using the delegate keyword
            Func<int, int, int> sum = delegate (int a, int b) { return a + b; };
            Console.WriteLine(sum(3, 4));  // output: 7
        }
    }
}
