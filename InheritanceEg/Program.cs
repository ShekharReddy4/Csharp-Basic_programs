using System;

namespace InheritanceEx
{
    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("Parent class default constructor");
        }

        public ParentClass(string p)
        {
            Console.WriteLine("Parentclass constructor with params");
        }

        public void PFname()
        {
            Console.WriteLine("pfname in baseclass");
        }
    }

    public class ChildClass : ParentClass
    {
        public ChildClass() : base("lol")
        {
            Console.WriteLine("Child class default constructor");
        }

        public ChildClass(string ccname) : base()
        {
            Console.WriteLine("Child class constructor with a params");
        }
        public new void PFname()
        {
            Console.WriteLine("pfname in Childclass");
            base.PFname();  // one way to access the base method
        }
    }

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("In the main function");
            ChildClass cc = new ChildClass("sajk");
            cc.PFname();


            Console.WriteLine("In the main function");
            ChildClass cc2 = new ChildClass();
            ((ParentClass)cc2).PFname();

            ParentClass p1 = new ChildClass();
            p1.PFname();

        }
    }
}
