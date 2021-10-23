using System;

namespace Csharp.ex2
{
    class Program
    {
        static void Main(string[] args)
        {
                int a = 3;
                int b  = 4;
                double x = 12.34;
                double y = 14.46;

                double sum = a + b + x + y;
                 
                Console.WriteLine("The sum  value in double datatype" + " " + sum );
                Console.WriteLine("The sum  value in integer datatype" + " " + Convert.ToInt32(sum));
        }
    }
}
