using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_Prog_Examples
{
    class Program
    {

        enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };
        enum SyncType
        {
            Text1 = 1,
            Text2 = 2,
            Text3 = 3,
        }

        static void Main(string[] args)
        {
            int WeekdayStart = (int)Days.Mon;
            int WeekdayEnd = (int)Days.Fri;

            Console.WriteLine("Monday: {0}", WeekdayStart);
            Console.WriteLine("Friday: {0}", WeekdayEnd);

            Console.WriteLine((int)SyncType.Text1);


            var SyncTypeVar = (SyncType)1;
            Console.WriteLine("After Type casting ------" + SyncTypeVar);
            string stringValue = SyncTypeVar.ToString();

            Console.WriteLine("String value ----- " + stringValue);

            //Another way to get the Text when you have a value; apart from the way of type casting
            Console.WriteLine(Enum.GetName(typeof(SyncType), 3));
        }
    }
}
