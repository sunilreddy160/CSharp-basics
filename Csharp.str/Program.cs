using System;

namespace Csharp.str
{
    class Program
    {
        static void Main(string[] args)

        {

            string a = "Hello";
            Console.WriteLine(a);
            Console.WriteLine(a.Length);
            //methods
            Console.WriteLine(a.ToLower());
            //concatenation
            string  firstname = "john";
            string  lastname  = "doe";
            string fullname = firstname + lastname;
            Console.WriteLine(fullname);
            //Access string chars
            string a1 = "sunil";
            Console.WriteLine(a1[4]);
            //add number and strings
            string x = "10";
            string c = "20";
            string q = x + c;
            Console.WriteLine(q);
        }
    }
}
