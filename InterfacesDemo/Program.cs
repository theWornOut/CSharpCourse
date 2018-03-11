namespace InterfacesDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var workers = new IWorker[]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };
            foreach (var worker in workers)
            {
                worker.Work();
            }

            var eats = new IEat[]
            {
                new Worker(),
                new Manager()
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }
        }
    }

    interface IWorker
    {
        void Work();
    }

    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker, IEat, ISalary
    {
        public void Work()
        {
            throw new System.NotImplementedException();
        }

        public void Eat()
        {
            throw new System.NotImplementedException();
        }

        public void GetSalary()
        {
            throw new System.NotImplementedException();
        }
    }

    class Worker : IWorker, IEat, ISalary
    {
        public void Work()
        {
            throw new System.NotImplementedException();
        }

        public void Eat()
        {
            throw new System.NotImplementedException();
        }

        public void GetSalary()
        {
            throw new System.NotImplementedException();
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            throw new System.NotImplementedException();
        }
    }
}