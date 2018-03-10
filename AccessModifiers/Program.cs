namespace AccessModifiers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
        }
    }

    // Default Internal
    // Bağlı bulunduğu proje içerisinde referans eklemeden kullanılır.
    internal class Customer
    {
        // Sadece tanımlanan yerden çağırılır.
        private int Id;

        // Private'ın bütün özelliklerini kapsar.
        // Tanımlanan özellik/değişken vs. inheritance(kalıtım) edildiği sınıflarında kullanılır.
        protected int Id2;

        public void Save()
        {

        }
    }

    class Student : Customer
    {
        public void Save2()
        {
            Customer customer = new Customer();
        }
    }

    public class Course
    {
        public string Name { get; set; }

        private class NestedClass
        {

        }
    }
}