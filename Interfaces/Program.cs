namespace Interfaces
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            InterfacesIntro();

            Demo();

            ICustomerDal[] customerDals = { new SqlServerCustomerDal(), new OracleServerCustomerDal(), new MyServerCustomerDal() };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            personManager.Add(new Customer { Id = 1, FirstName = "Ekrem", LastName = "Alpay", Address = "Istanbul" });
            personManager.Add(new Student { Id = 2, FirstName = "Alpay", LastName = "Ekrem", Departmant = "Computer Engineering" });
            personManager.Add(new Worker { Id = 3, FirstName = "Bla", LastName = "Cla", Departmant = "IT" });
        }
    }

    internal interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }

    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}