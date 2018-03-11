namespace Collections
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    internal class Program
    {
        private static void Main(string[] args)
        {
            ArrayListMethod();

            ListMethod();

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            var dictionaryCount = dictionary.Count;
            var containsKey = dictionary.ContainsKey("glass");
            var containsValue = dictionary.ContainsValue("phone");

            Console.ReadLine();
        }

        private static void ListMethod()
        {
            List<string> cities = new List<string> { "Istanbul" };
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            List<Customer> customers = new List<Customer>
            {
                new Customer {Id = 1, Name = "Ekrem"},
                new Customer {Id = 2, Name = "Alpay"}
            };

            var customer = new Customer
            {
                Id = 3,
                Name = "Emre"
            };
            customers.Add(customer);
            customers.AddRange(new Customer[2]
            {
                new Customer
                {
                    Id =4, Name = "Ali"
                },
                new Customer
                {
                    Id = 5,Name = "Ezgi"
                }
            });

            var count = customers.Count;
            var contains = customers.Contains(customer);
            var indexOf = customers.IndexOf(customer);
            var lastIndexOf = customers.LastIndexOf(customer);
            customers.Insert(0, customer);
            customers.Remove(customer);
            customers.RemoveAll(c => c.Name == "Istanbul");

            foreach (var item in customers)
            {
                Console.WriteLine(item.Name);
            }
        }

        private static void ArrayListMethod()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Istanbul");
            cities.Add("Ankara");
            cities.Add("Izmir");
            cities.Add(1);
            cities.Add(true);

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}