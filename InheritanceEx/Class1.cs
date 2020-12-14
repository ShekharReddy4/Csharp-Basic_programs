using System;

namespace InheritanceEx
{
    public class ParentClass
    {
        public ParentClass()
        {

        }

        public ParentClass(string p)
        {
            Console.WriteLine("Parentclass constructor with params");
        }
    }

    public class ChildClass : ParentClass
    {
        public ChildClass()
        {

        }

        public ChildClass(string ccname)
        {
            Console.WriteLine("Child class constructor with a params");
        }
    }

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("In the main function");
        }
    }
}
