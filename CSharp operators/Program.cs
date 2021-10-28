using System;

namespace CSharp_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //assignmet a = 6 (=) is assignmetn operator
            // int a = 6;
            //Console.WriteLine(a);
            //arthimetic oprator
            int b = 65, c = 46;
            int result = b + c;
            Console.WriteLine("Value is :" + result);
            //
            int result1 = b - c;
            Console.WriteLine("Value is :" + result);
            int result2 = b * c;
            Console.WriteLine("Value is:" + result2);
            int result3 = b / c;
            Console.WriteLine(result3);
            //relational
            bool result4 = b == c;
            Console.WriteLine(result4);
            //logical
            bool result5 = b > c || c > b;
            bool result6 = b > c && c > b;
            Console.WriteLine(result5);
            Console.WriteLine(result6);
            //terenary 
            string result7 = (b > c) ? "yes" : "no";
            Console.WriteLine(result7);
            //math operator
            Console.WriteLine("Minimu value is: " + Math.Min(b, c)) ;
            Console.WriteLine( "maximum value is:" + Math.Max(b, c));
            Console.WriteLine(Math.Sqrt( c));
            Console.WriteLine( "nearest value is:" + Math.Round(-7.44));
            Console.WriteLine(Math.Abs(-7.44));
        }
    }
}