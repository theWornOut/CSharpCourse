namespace AbstractClasses
{
    using System;

    // Interface ile Virtual Metotların birleşimidir.
    // Tamamen inheritance amaçlı kullanılır.
    // Interfaces gibi abstract classes new'lenmez. Instance'i alınmaz.
    internal class Program
    {
        private static void Main(string[] args)
        {
            Database database = new Oracle();
            database.Add();
            database.Delete();

            Database database2 = new SqlServer();
            database2.Add();
            database2.Delete();
        }
    }

    abstract class Database
    {
        // Abstract classes ile tamamlanmış ve tamamlanmamış metotlar oluşturmak mümkün.
        // Interfaces gibidir. Tek bir sınıfa inheritance edilir.
        public void Add()
        {
            Console.WriteLine("Added by default");
        }

        // İçi dolu olmayan virtual metotdur.
        public abstract void Delete();
    }

    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Sql");
        }
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }
}