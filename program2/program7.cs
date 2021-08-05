using System;
using System.Collections.Generic;
using System.Text;

namespace program2
{
    class program7
    {
        public static void disply()
        { 
            int a = 4;
            int b = 6;
            int temp = 0;
            Console.WriteLine("Before Swapping a:"+ a +"b:"+b);
            temp = a;
            a = b;
            b = temp;
            Console.Write("After Swapping");
            Console.Write("First Number : " + a);
            Console.Write("Second Number : " + b);
            Console.ReadLine();
            }
    }
}
