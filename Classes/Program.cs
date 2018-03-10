namespace Classes
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Ekrem";
            customer.LastName = "Alpay";
            customer.City = "Istanbul";

            Customer customer2 = new Customer
            {
                Id = 2,
                FirstName = "Ekrem",
                LastName = "Alpay",
                City = "Istanbul"
            };

            Console.ReadLine();
        }
    }
}