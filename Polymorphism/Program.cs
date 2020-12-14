using System;

namespace Polymorphism
{
    class Employee
    {
        public string fn = "FN";
        public string ln  = "LN";
        public  void PrintFullName()
        {
            Console.WriteLine("{0}", this.fn + "   " + this.ln + " Parent Employee");
        }
    }
    class PartTimeEmployee : Employee
    {
        public  void PrintFullName()
        {
            Console.WriteLine("{0}", this.fn + "   " + this.ln + " PartTime Emp");
        }
    }
    class FullTimeEmployee : Employee
    {
        public new  void PrintFullName()
        {
            Console.WriteLine("{0}", this.fn + "   " + this.ln + " Fulltime Emp");
        }
    }
    class TemporaryEmployee : Employee
    {
        public  void PrintFullName()
        {
            Console.WriteLine("{0}", this.fn + "   " + this.ln + " TemporaryEmp");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] e = new Employee[5];
            //e[0] = new Employee();
            e[1] = new PartTimeEmployee();
            e[2] = new FullTimeEmployee();
            e[3] = new TemporaryEmployee();
            e[4] = new Employee();

            Console.WriteLine("------------Using Parentclass references---------");

            //e[0].PrintFullName(); //base class

            e[1].PrintFullName(); //partime class new keyword
            e[2].PrintFullName(); //fulltime class override keyword
            e[3].PrintFullName(); //tmpclass override class

            //e[4].PrintFullName(); // normal base class again

            // Overridig a method happens only when exclusively mentioned
            // you must put the virtual keyword in the parent class and override keyword in the child class


            Console.WriteLine("------------Using Childclass references---------");

            PartTimeEmployee pe = new PartTimeEmployee();
            FullTimeEmployee fe = new FullTimeEmployee();
            TemporaryEmployee te = new TemporaryEmployee();

            while (true)
            {
                Console.WriteLine("ex");
            }

            pe.PrintFullName();
            fe.PrintFullName();
            te.PrintFullName();

        }
    }
}
