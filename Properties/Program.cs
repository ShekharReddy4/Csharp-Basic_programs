using System;

namespace Properties
{
    public class ParentClass
    {
        private int _id;
        private string _name;
        private static int _passmark = 35;


        // compilet automatically creates a private field and adds the property for that field
        public string EmailID { get; set; }

        public int Id
        {
            get
            {
                return this._id;
            }
            set
            {
                // in set we can add condition and business logic for assigning values to the fields
                this._id = value;
            }
        }

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                // in set we can add condition and business logic for assigning values to the fields
                this._name = value;
            }
        }

        public int Passmark
        {
            get
            {
                // making it readonly because it has only get method but not the set method
                return ParentClass._passmark;
            }
        }

    }

    
    public class Program
    {
        public static void Main()
        {
            ParentClass p = new ParentClass();

            //Set and Get accessors are used instead of private variables
            p.Id = 123;
            Console.WriteLine(p.Id);

            p.Name = "shekhar";
            Console.WriteLine(p.Name);

            Console.WriteLine(p.Passmark);

            p.EmailID = "s@gmail,co";
            Console.WriteLine(p.EmailID);

        }
    }
}
