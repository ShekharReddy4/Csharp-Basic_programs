using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodEg
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    ////StringHelper sh = new StringHelper();
        //    //Console.WriteLine(StringHelper.ChangeTheCase("hello instance"));

        //    //Console.WriteLine(StringHelper.ChangeTheCase("hello"));

        //}

        delegate void Printer();
        static void Main()
        {
            List<Printer> printers = new List<Printer>();

            int i = 0;

            for (; i < 10; i++)

            {
                printers.Add(delegate { Console.WriteLine(i); });
            }

            foreach (var printer in printers)
            {
                printer();//print 10
            }
        }
    }


    //public class TestStatic
    //{
    //    public static int TestValue;

    //    public TestStatic()
    //    {
    //        if (TestValue == 0)
    //        {
    //            TestValue = 5;
    //        }
    //    }

    //    static TestStatic()
    //    {
    //        if (TestValue == 0)
    //        {
    //            TestValue = 10;
    //        }
    //    }
    //    public void Print()
    //    {
    //        if (TestValue == 5)
    //        {
    //            TestValue = 6;
    //        }
    //        Console.WriteLine("TestValue : " + TestValue);
    //    }

    //    public static void Main(string[] args)
    //    {
    //        TestStatic t = new TestStatic();

    //        t.Print();//10
    //    }
    //}

    
    // this could be in anothet file too.. no need to be in this file itself

    // has to be a static class for having implementation of an extension method.
    //class StringHelper
    //{
    //    // which class you are trying to extend then that should be the first param to the extended method 
    //    // and that param must be preceded with this keyword
    //    public static string ChangeTheCase(this string inputstring)
    //    {
    //        char[] charArray = inputstring.ToCharArray();
    //        charArray[0] = char.IsUpper(charArray[0]) ? char.ToLower(charArray[0]) : char.ToUpper(charArray[0]);
    //        return new string(charArray);
    //    }
    //}
}
