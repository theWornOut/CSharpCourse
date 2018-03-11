﻿namespace Conditionals
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            const int number = 10;

            // İf - Else If - Else
            if (number == 10)
            {
                Console.WriteLine("Number is 10 !");
            }
            else if (number == 20)
            {
                Console.WriteLine("Number is 20 !");
            }
            else
            {
                Console.WriteLine("Number is not 10 or 20 !");
            }

            // Single Line If - Ternary If
            Console.WriteLine(number == 11 ? "Number is 10 !" : "Number is not 10 !");

            // Switch - Case
            switch (number)
            {
                case 11:
                    Console.WriteLine("Number is 10 !");
                    break;
                case 15:
                    Console.WriteLine("Number is 20 !");
                    break;
                default:
                    Console.WriteLine("Number is not 10 or 20 !");
                    break;
            }

            // Demo
            if (number >= 0 && number <= 100)
            {
                Console.WriteLine("Number is between 0-100");
            }
            else if (number > 100 && number <= 200)
            {
                Console.WriteLine("Number is between 101-200");
            }
            else if (number > 200 || number < 0)
            {
                Console.WriteLine("Number is less than 0 or greater than 200");
            }

            // Nested If
            if (number < 100)
            {
                if (number >= 90 && number < 95)
                {
                    Console.WriteLine("Number is between 90-94");
                }
                else
                {
                    Console.WriteLine("Number is not between 90-94");
                }
            }

            Console.ReadLine();
        }
    }
}