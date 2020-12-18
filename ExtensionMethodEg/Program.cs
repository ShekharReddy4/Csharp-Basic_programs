using System;

namespace ExtensionMethodEg
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringHelper sh = new StringHelper();
            Console.WriteLine(StringHelper.ChangeTheCase("hello instance"));

            Console.WriteLine(StringHelper.ChangeTheCase("hello"));
        }
    }

    // this could be in anothet file too.. no need to be in this file itself
    // but the class has to be a NON GENERIC STATIC CLASS for having implementation of an extension method.
    static class StringHelper
    {
        // which class you are trying to extend then that SHOULD BE THE FIRST PARAM to the extended method 
        // and that param must be PRECEDED WITH THIS KEYWORD
        public static string ChangeTheCase(this string inputstring)
        {
            char[] charArray = inputstring.ToCharArray();
            charArray[0] = char.IsUpper(charArray[0]) ? char.ToLower(charArray[0]) : char.ToUpper(charArray[0]);
            return new string(charArray);
        }
    }
}
