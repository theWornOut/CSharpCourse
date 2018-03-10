namespace Constructors
{
    using System;

    // Singleton Design Pattern
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.List();

            Product productLaptop = new Product { Id = 1, Name = "Laptop" };
            Product productDesktop = new Product(2, "Desktop");

            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            employeeManager.Add();

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            Teacher.Number = 10;
            Utilities.Validate();

            Manager.DoSomething();
            Manager manager = new Manager();
            manager.DoSomething2();

            Console.ReadLine();
        }
    }
    // Constructor Overload
    class CustomerManager
    {
        private int _count = 10;
        public CustomerManager(int count)
        {
            _count = count;
        }

        public CustomerManager()
        {
        }

        public void List()
        {
            Console.WriteLine($"Listed {_count}!");
        }

        public void Add()
        {
            Console.WriteLine("Added!");
        }
    }

    class Product
    {
        private int _id;
        private string _name;
        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public Product()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }

    // Constructor Injection
    class EmployeeManager
    {
        private ILogger _logger;

        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added!");
        }
    }

    class BaseClass
    {
        private string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }

        public void Message()
        {
            Console.WriteLine($"{_entity} message!");
        }
    }

    // Parametreyi base sınıf için kullanıyor
    class PersonManager : BaseClass
    {
        public PersonManager(string entity) : base(entity)
        {

        }

        public void Add()
        {
            Console.WriteLine("Added!");
            Message();
        }
    }

    // Instance oluşturulmaz.
    // Ortak nesnelerdir.
    // Arkaplanda tek bir nesne create edilip, tüm uygulama onu kullanır.
    static class Teacher
    {
        public static int Number { get; set; }
    }

    static class Utilities
    {
        // Validations operations
        static Utilities()
        {

        }

        public static void Validate()
        {
            Console.WriteLine("Validation is done!");
        }
    }

    class Manager
    {
        public static void DoSomething()
        {
            Console.WriteLine("Done!");
        }

        public void DoSomething2()
        {
            Console.WriteLine("Done2!");
        }
    }
}