using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Examples
{
    /// <summary>
    /// User Defined Exception example
    /// </summary>

    public class TempIsZeroException : Exception
    {
        public TempIsZeroException(string message) : base(message)
        {
        }
    }
    public class Temperature
    {
        int temperature = 0;

        public void showTemp()
        {

            if (temperature == 0)
            {
                throw (new TempIsZeroException("Zero Temperature found"));
            }
            else
            {
                Console.WriteLine("Temperature: {0}", temperature);
            }
        }
    }

    class DivNumbers
    {
        int result;

        DivNumbers()
        {
            result = 0;
        }
        public void division(int num1, int num2)
        {
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            finally
            {
                Console.WriteLine("Result: {0}", result);
            }
        }
        class TestTemperature
        {
            static void Main(string[] args)
            {
                Temperature temp = new Temperature();
                try
                {
                    temp.showTemp();
                }
                catch (TempIsZeroException e)
                {
                    Console.WriteLine("TempIsZeroException: {0}", e.Message);
                }

                // Normal Exception Handling whenever there is already an exception which is builtin is occurred

                DivNumbers d = new DivNumbers();
                d.division(25, 0);
            }
        }
    }
}