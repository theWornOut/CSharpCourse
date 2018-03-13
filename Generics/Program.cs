namespace Generics
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Istanbul", "Izmir", "Ankara");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            List<Customer> resultCustomers = utilities.BuildList<Customer>(new Customer { Name = "Ekrem" }, new Customer { Name = "Alpay" });
            foreach (var customer in resultCustomers)
            {
                Console.WriteLine(customer.Name);
            }

            Console.ReadLine();
        }
    }

    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }

    class Product : IEntity
    {

    }

    interface IProductDal : IRepository<Product>
    {

    }

    class Customer : IEntity
    {
        public string Name { get; set; }
    }

    interface ICustomerDal : IRepository<Customer>
    {

    }

    class Student : IEntity
    {

    }

    interface IEntity
    {

    }

    interface IStudentDal : IRepository<Student>
    {

    }

    interface IStruct<T> where T : struct
    {

    }

    interface IRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }

    class ProductDal : IProductDal
    {
        public List<Product> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Add(Product entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new System.NotImplementedException();
        }
    }

    class CustomerDal : ICustomerDal
    {
        public List<Customer> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Add(Customer entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new System.NotImplementedException();
        }
    }
}