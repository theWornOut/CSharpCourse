namespace TypesAndVariables
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            // Value Type
            const byte numberByte = 255; // 8 byte
            const short numberShort = 32767; // 16 byte
            const int numberInt = 2147483647; // 32 byte
            const long numberLong = 214748364741324; // 64 byte

            const double numberDouble = 10.4; // 64 byte
            const decimal numberDecimal = 64.63M; // 64 byte
            Console.WriteLine($"{numberByte}" + " - " + $"{numberShort}" + " - " + $"{numberInt}" + " - " + $"{numberLong}" + " - " + $"{numberDouble}" + " - " + $"{numberDecimal}");

            const bool condition = true;
            Console.WriteLine($"{condition}");

            const char character = 'E';
            Console.WriteLine($"{character}");
            Console.WriteLine($"{(int)character}");

            Console.WriteLine(Days.Friday);

            var varType = "Magic";
            Console.WriteLine($"{varType}");

            // Reference Type
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