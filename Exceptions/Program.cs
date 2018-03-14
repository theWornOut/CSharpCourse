namespace Exceptions
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        private static void Main(string[] args)
        {
            //ExceptionIntro();

            //TryCatch();

            //ActionDemo();

            // in, in, out result
            Func<int, int, int> add = Add;
            Console.WriteLine(add(3, 5));
            Console.WriteLine(Add(2, 3));

            // out result
            Func<int> getRandomNumber = delegate
            {
                Random random = new Random();
                return random.Next(1, 100);
            };
            Console.WriteLine(getRandomNumber);

            // Without Parameter - Use to Lambda
            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);
            Console.WriteLine(getRandomNumber2);

            Console.ReadLine();
        }

        private static int Add(int x, int y)
        {
            return x + y;
        }

        private static void ActionDemo()
        {
            HandleException(() => { Find(); });
        }

        private static void TryCatch()
        {
            try
            {
                Find();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Ekrem", "Alpay", "Ali" };
            if (!students.Contains("Emre"))
            {
                throw new RecordNotFoundException("Record Not Found!");
            }
            else
            {
                Console.WriteLine("Record Found!");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                var students = new string[3] { "Ekrem", "Alpay", "Emre" };
                students[3] = "Ali";
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}