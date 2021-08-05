using System;
using System.Collections.Generic;
using System.Text;

namespace program2
{
    class Program8
    {
        public static void OddAndEven()
        {
            int i;
            Console.Write("Enter a Number : ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write("Entered Number is an Even Number" + i);
            }
            else
            {
                Console.Write("Entered Number is an Odd Number" + i);
                
            }
        }
    }
}
