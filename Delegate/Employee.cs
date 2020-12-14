using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class LibClass<T>
    {
        public delegate bool dPromotable(T e);
        public delegate void dPrintPromotes(T e);

        public void PromotableEmployees<TT>(List<T> list_of_employees, dPromotable isPromotable, dPrintPromotes promotedNamesPrint)
        {
            foreach (T t in list_of_employees)
            {
                if (isPromotable(t))
                {
                    promotedNamesPrint(t);
                }
            }
        }
    }
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }


        //public static bool isPromotable_logic_func(Employee emp)
        //{
        //    return emp.Salary > 5 ? true : false;
        //}
        //public static void printPromotes_logic_func(Employee emp)
        //{
        //    Console.WriteLine("{0} is Promoted!! ", emp.Name);
        //}


        public static void Main2(string[] args)
        {
            List<Employee> empList = new List<Employee>();

            empList.Add(new Employee { Id = 1, Salary = 3, Name = "Ram" });
            empList.Add(new Employee { Id = 1, Salary = 3, Name = "som" });
            empList.Add(new Employee { Id = 1, Salary = 35, Name = "Rani" });
            empList.Add(new Employee { Id = 1, Salary = 35, Name = "Vani" });
            empList.Add(new Employee { Id = 1, Salary = 3, Name = "Soni" });

            LibClass<Employee> lcc = new LibClass<Employee>();

            //Delegate instances
            //LibClass<Employee>.dPromotable dvar = new LibClass<Employee>.dPromotable(isPromotable_logic_func);
            //LibClass<Employee>.dPrintPromotes dvarp = new LibClass<Employee>.dPrintPromotes(printPromotes_logic_func);

            lcc.PromotableEmployees<Employee>(empList, dvar => dvar.Salary > 5, dvarp => Console.WriteLine("{0} is Promoted!! ", dvarp.Name));
        }
    }

}