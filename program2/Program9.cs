﻿using System;
using System.Collections.Generic;
using System.Text;

namespace program2
{
    class Program9
    {
        public static void vowelsAndConstants()
        {
            char ch;

            Console.WriteLine("Enter any character: ");
            ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {

                Console.WriteLine(ch + " is Vowel");

            }
            else if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine(ch + " is Consonant");
            }

            Console.ReadLine();
        }
    }
}
