namespace TypesAndVariables
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            const byte numberByte = 255;
            const short numberShort = 32767;
            const int numberInt = 2147483647;
            const long numberLong = 214748364741324;

            const double numberDouble = 10.4;
            const decimal numberDecimal = 64.63M;
            Console.WriteLine($"{numberByte}" + " - " + $"{numberShort}" + " - " + $"{numberInt}" + " - " + $"{numberLong}" + " - " + $"{numberDouble}" + " - " + $"{numberDecimal}");

            const bool condition = true;
            Console.WriteLine($"{condition}");

            const char character = 'E';
            Console.WriteLine($"{character}");
            Console.WriteLine($"{(int)character}");

            Console.WriteLine(Days.Friday);

            var varType = "Magic";
            Console.WriteLine($"{varType}");

            const string referenceType = "Reference type";
            Console.WriteLine($"{referenceType}");

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }

    enum Days
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}