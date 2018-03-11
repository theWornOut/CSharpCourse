namespace Exceptions
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        private static void Main(string[] args)
        {
            ExceptionIntro();

            try
            {
                Find();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }

            HandleException(() =>
            {
                Find();
            });

            Console.ReadLine();
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