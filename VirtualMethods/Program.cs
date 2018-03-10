namespace VirtualMethods
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySql mySql = new MySql();
            mySql.Add();

            Console.ReadLine();
        }
    }

    // Çoğu operasyonda aynı işlemi gerçekleştirecek, bazı yerlerde değişecekse metot ezilmeli.
    // Override edilmeli. Bunun için virtual metot tanımlanmalı.
    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by default");
        }

        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default");
        }
    }

    class SqlServer : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by Sql Code");
            //base.Add();
        }
    }

    class MySql : Database
    {

    }
}