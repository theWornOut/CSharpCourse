namespace AccessModifiers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
        }
    }

    internal class Customer
    {
        private int Id;
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