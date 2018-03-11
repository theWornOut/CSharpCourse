namespace ReferenceAndValueType
{
    using System;
    using System.Data;

    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;
            Console.WriteLine(number2);

            string[] cities1 = { "Istanbul", "Ankara" };
            string[] cities2 = { "Antalya", "Bursa" };
            cities2 = cities1;
            cities1[0] = "İzmir";
            Console.WriteLine(cities2[0]);

            DataTable dataTable1;
            DataTable dataTable2 = new DataTable();
            dataTable1 = dataTable2;

            Console.ReadLine();
        }
    }
}