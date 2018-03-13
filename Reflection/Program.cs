namespace Reflection
{
    using System;
    using System.Reflection;

    internal class Program
    {
        private static void Main(string[] args)
        {
            // Regular Script
            MathOperations mathOperations = new MathOperations(2, 3);
            Console.WriteLine(mathOperations.Add2());
            Console.WriteLine(mathOperations.Add(3, 4));
            Console.WriteLine("***********************");

            // Create Instance
            var type = typeof(MathOperations);
            MathOperations mathOperations2 = (MathOperations)Activator.CreateInstance(type, 6, 7);
            Console.WriteLine(mathOperations2.Add(4, 5));
            Console.WriteLine(mathOperations2.Add2());
            Console.WriteLine("***********************");

            //Method Info
            var instance = Activator.CreateInstance(type, 6, 7);
            MethodInfo methodInfo = instance.GetType().GetMethod("Add2");
            Console.WriteLine(methodInfo?.Invoke(instance, null));
            Console.WriteLine("***********************");

            var methods = type.GetMethods();
            foreach (var method in methods)
            {
                Console.WriteLine($"Method Name : {method.Name}");
                foreach (var parameterInfo in method.GetParameters())
                {
                    Console.WriteLine($"Parameter Name : {parameterInfo.Name}");
                }

                foreach (var customAttribute in method.GetCustomAttributes())
                {
                    Console.WriteLine($"Attribute Name : {customAttribute.GetType().Name}");
                }
            }

            Console.ReadLine();
        }
    }

    public class MathOperations
    {
        private readonly int _number1;
        private readonly int _number2;
        public MathOperations(int number1, int number2)
        {
            _number1 = number1;
            _number2 = number2;
        }

        public MathOperations()
        {

        }

        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Multi(int number1, int number2)
        {
            return number1 * number2;
        }

        public int Add2()
        {
            return _number1 + _number2;
        }

        [MethodName("Multiplication")]
        public int Multi2()
        {
            return _number1 * _number2;
        }
    }

    class MethodNameAttribute : Attribute
    {
        private string _name;
        public MethodNameAttribute(string name)
        {
            this._name = name;
        }
    }
}