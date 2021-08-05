using System;

namespace program2
{
    class Program
    {
        static double FindpercentageofHead(int numberofTimesCoinTossed)
        {
            Random rand = new Random();
            int HEADS = 1;
            double headsCount = 0;

            for (int i = 0; i < numberofTimesCoinTossed; i++)
            {
                int coinTossed = rand.Next(0, 2);
                if (coinTossed == HEADS)
                {
                    Console.WriteLine("Heads");
                    headsCount++;
                }
                else
                {
                    Console.WriteLine("Tails");
                }

            }
            return (headsCount / numberofTimesCoinTossed) * 100;
        }
        static double FindPercentageofTails(double headsPercentage)
        {
            return 100 - headsPercentage;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of times coin tossed");
            int numberofTimesCoinTossed = int.Parse(Console.ReadLine());
            double headsPercentage = FindpercentageofHead(numberofTimesCoinTossed);
            double tailPercentage = FindPercentageofTails(headsPercentage);
            Console.WriteLine("Heads Percentage" + headsPercentage);
            Console.WriteLine("Tails Percentage" + tailPercentage);


            Program1.LeapYear();

            Program3.ToFindPower();

            Program4.HarmonicNumber();

            Program5.Factors();

            Program6.QuotientAndReminder();

            program7.disply();

            Program8.OddAndEven();

            Program9.vowelsAndConstants();

            Program10.LargestNumbers();

        }
    }
}
