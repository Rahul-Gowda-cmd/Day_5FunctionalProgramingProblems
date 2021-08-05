using System;
using System.Collections.Generic;
using System.Text;

namespace program2
{
    class Program10
    {
        public static void LargestNumbers()
        {
            int num1, num2, num3;
            num1 = 5;
            num2 = 8;
            num3 = 4;
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("Number one is the largest"+num1);
                }
                else
                {
                    Console.Write("Number three is the largest"+num3);
                }
            }
            else if (num2 > num3)
                Console.Write("Number two is the largest"+num2);
            else
                Console.Write("Number three is the largest"+num3);
        }
    
    }
}
