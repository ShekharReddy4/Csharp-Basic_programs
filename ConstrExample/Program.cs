using System;

namespace ConstrExample
{

    class A
    {
        private A()
        {
            Console.WriteLine("Param less Constructor in A");
        }
        public A(string s)
        {
            Console.WriteLine("Parametered overloaded Constructor in A");
        }
        static A()//we cannot use the access modifiers on static constructors
        {
            Console.WriteLine("Static constructor in A");
        }
        private A(string s, string s2)// you cannot have more than oen overloaded constructor with public/private access modifiers
        {
            Console.WriteLine("Parametered Private Constructor in A");
        }
    }

    class B
    {
        //public B()
        //{
        //    Console.WriteLine("parameterless constructor in B");
        //}

        // A class with only a private constructor and all static fields and a static ocntructor cannot be instantiated
        //private B( string s)
        //{
        //    Console.WriteLine("parametered static constructor in B");
        //}

        static B()
        {
            Console.WriteLine(" static constructor in B");
        }
        public B()
        {
            Console.WriteLine(" instance constructor in B");
        }
        public static void Mm()
        {
            Console.WriteLine("mm method static");
        }
    }

    class C:B
    {
        public void Mj()
        {
            Console.WriteLine("from Mj mthod in C");
        }
    }


    public class c1
    {
        public int ji;
        public void outerclassmethod()
        {
            Console.WriteLine("calling from the outer class method");
        }
        public class c2
        {
            public int h;
            public c2()
            {
                this.h = 23;
                c1 v = new c1();
                v.outerclassmethod();
            }
            public void nem()
            {
                Console.WriteLine("calling from the nested class methodnm");

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //A a = new A("kafka");
            //B b = new B();
            //B bb = new B();
            //B.Mm();

            //C c = new C();
            //c.Mj();
            //B b = new B("ssdas");

            c1 c1i = new c1();
            Console.WriteLine(c1i.ji);
            c1.c2 nestedInstance = new c1.c2();
            nestedInstance.nem();

        }
    }
}
