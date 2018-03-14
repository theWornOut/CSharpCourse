namespace Events
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Product harddiskProduct = new Product(50) { ProductName = "Hard Disk" };
            Product gsmProduct = new Product(50) { ProductName = "GSM" };
            gsmProduct.StockControlEvent += GsmProduct_StockControlEvent;

            for (int i = 0; i < 10; i++)
            {
                harddiskProduct.Sell(10);
                gsmProduct.Sell(10);
                Console.ReadLine();
            }

            Console.ReadLine();
        }

        private static void GsmProduct_StockControlEvent()
        {
            Console.WriteLine("Gsm about to finish!");
        }
    }
}