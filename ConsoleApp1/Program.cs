using System;
using PATA = ProjectA.TeamA;
using PATB = ProjectA.TeamB;
using DSTCL = DotnetStdCL;

/// <summary>
/// This Program explains the dependicies from one Project to another inthe same Solution
/// </summary>
namespace ConsoleApp1
{
    class Customer
    {
        string _fname;
        string _lname;

        public Customer(): this("lol", "lol2")
        {
            
        }
        public Customer(string a, string b)
        {
            this._fname = a;
            this._lname = b;
        }

        public void PrintName()
        {
            Console.WriteLine("full name is {0}", this._fname+" "+this._lname);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();
            c.PrintName();

            Customer c2 = new Customer("w", "ws");
            c2.PrintName();

        }
    }
}
