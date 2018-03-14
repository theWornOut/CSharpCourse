namespace Delegates
{
    using System;

    public delegate void MyDelegate();
    public delegate void MyDelegate2(string text);
    public delegate int MyDelegate3(int number1, int number2);

    internal class Program
    {
        private static void Main(string[] args)
        {
            // Normal
            CustomerManager customerManager = new CustomerManager();
            customerManager.SendMessage();
            customerManager.ShowAlert();

            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert;
            myDelegate -= customerManager.SendMessage;
            myDelegate();

            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.ShowAlert2;
            myDelegate2("Hello my delegate 2");

            MathOperations mathOperations = new MathOperations();
            MyDelegate3 myDelegate3 = mathOperations.Add;
            myDelegate3 += mathOperations.Multi;
            var result = myDelegate3(2, 3);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }

    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello!");
        }

        public void ShowAlert()
        {
            Console.WriteLine("Be careful!");
        }

        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }

        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }
    }

    public class MathOperations
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Multi(int number1, int number2)
        {
            return number1 * number2;
        }
    }
}