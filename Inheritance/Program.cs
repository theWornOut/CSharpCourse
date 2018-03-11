namespace Inheritance
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Customer customer = new Customer();

            var persons = new[]
            {
                new Customer
                {
                    FirstName = "Ekrem"
                },
                new Student
                {
                    FirstName = "Alpay"
                },
                new Person
                {
                    FirstName = "Hakan"
                }
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }

            Console.ReadLine();
        }
    }

    class Person2
    {

    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string City { get; set; }
    }
}