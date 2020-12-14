using System.Linq;
using System;
using System.Collections;
using System.Collections.Generic;


/// <summary>
/// Program to demo basic collectino usage and generic collection usages and what is Type safety and type Unsafety
/// </summary>
namespace Collections_Experiments
{
    class Program
    {
        public static void Type_UnSafe_Collection_Usage()
        {
            /*
             Type safety example

            Here the below program will definitely combine though we pass "3" to the integer.Add("3ss") is a string -- This is NOT Type Safe
             Therefore,  Normal collections are called NOT Type safe whereas generic collection are TYPESAFE
             */
            var integers = new ArrayList();
            integers.Add(1);
            integers.Add(2);
            integers.Add("3ss");

            for (int i = 0; i < integers.Count; ++i)
            {
                int integerr = (int)integers[i];
                // do something
            }
        }

        public static void Queue_Collection_imple()
        {
            // Normal Collection usage another example
            // Creating a Queue 
            Queue myQueue = new Queue();

            // Inserting the elements into the Queue 
            myQueue.Enqueue("C#");
            myQueue.Enqueue("PHP");
            myQueue.Enqueue("Perl");
            myQueue.Enqueue("Java");
            myQueue.Enqueue("C");

            // Displaying the count of elements 
            // contained in the Queue 
            Console.Write("Total number of elements present in the Queue are: ");

            Console.WriteLine(myQueue.Count);

            // The below two lines show that the normal collections are not type safe
            int c = (int)myQueue.Peek();
            Console.WriteLine("{0}", c);

            // Displaying the beginning element of Queue 
            Console.WriteLine("Beginning Item is: " + myQueue.Peek());

        }

        public static void Generic_collection_implem_type_safe_at_compileTime()
        {
            // Generic Collections Usage
            // Creating a List of integers 
            List<int> mylist = new List<int>();

            // adding items in mylist 
            for (int j = 5; j < 10; j++)
            {
                mylist.Add(j * 3);
            }

            // Displaying items of mylist 
            // by using foreach loop 
            foreach (int items in mylist)
            {
                Console.WriteLine(items);
            }
        }


        public static void Main(string[] args)
        {
            Type_UnSafe_Collection_Usage();


            // THIS IS REPETITIVE
            //Normal queue calling, Note: this is an additional example of implementation of normal collection
            Queue_Collection_imple();

            //Using a type safe collection 
            Generic_collection_implem_type_safe_at_compileTime();


        }
    }
}


