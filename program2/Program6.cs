using System;
using System.Collections.Generic;
using System.Text;

namespace program2
{
    class Program6
    {
        public static void QuotientAndReminder()
        {
            int a = 60;
            int b = 7;

            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
            Console.ReadLine();

        }
    }
}
