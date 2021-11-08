using System;

namespace CSharp_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*do while 
            int i = 3;
            do
            {
                Console.WriteLine(i);
                i = i + 1;
            }*/
          //  while (i < 3);
            //while
            /* int i1 = 2;
             while (i1 < 5) 
             {
                 Console.WriteLine(i1);
                 i1 = i1 + 1;
             }*/
          //for loop
            int i = 3;
            for (i = 3; i < 6; i++)  
            {
                if(i==5)
                {
                    // break;
                    continue;
                }
                Console.WriteLine(i);
            }
            
           

        }
    }
}
