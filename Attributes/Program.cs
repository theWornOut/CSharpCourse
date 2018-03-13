namespace Attributes
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, LastName = "Alpay", Age = 26 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);

            Console.ReadLine();
        }
    }

    [ToTable("Customers")]
    class Customer
    {
        public int Id { get; set; }

        [RequiredProperty]
        public string FirstName { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }
    }

    class CustomerDal
    {
        [Obsolete("Don't use Add, instead use AddNew Method")]
        public void Add(Customer customer)
        {
            Console.WriteLine($"{customer.Id} - {customer.FirstName} - {customer.LastName} - {customer.Age} added!");
        }

        public void AddNew(Customer customer)
        {
            Console.WriteLine($"{customer.Id} - {customer.FirstName} - {customer.LastName} - {customer.Age} added!");
        }
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
    class RequiredPropertyAttribute : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Class)]
    class ToTableAttribute : Attribute
    {
        private string _tableName;
        public ToTableAttribute(string tableName)
        {
            this._tableName = tableName;
        }
    }
}