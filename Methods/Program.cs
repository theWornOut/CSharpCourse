namespace Methods
{
    using System;
    using System.Linq;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Add();
            var result = Add2(10);
            Console.WriteLine($"Result = {result}");

            int number1 = 20;
            const int number2 = 100;
            var result2 = Add3(ref number1, number2);
            Console.WriteLine($"Result 2 = {result2}");

            Console.WriteLine(Multiply(5, 2));
            Console.WriteLine(Multiply(5, 2, 6));

            Console.WriteLine(Add4(2, 3, 5, 7, 1, 2, 5));

            Console.ReadLine();
        }

        private static void Add()
        {
            Console.WriteLine("Added!");
        }

        private static int Add2(int number1, int number2 = 30)
        {
            return number1 + number2;
        }

        private static int Add3(ref int number1, int number2)
        {
            if (number1 <= 0) throw new ArgumentOutOfRangeException(nameof(number1));
            number1 = 30;
            return number1 + number2;
        }

        private static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        private static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        private static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}