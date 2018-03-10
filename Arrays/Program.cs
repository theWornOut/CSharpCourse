namespace Arrays
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var students = new string[2] { "Ekrem", "Alpay" };
            students[0] = "Alpay";
            students[1] = "Ekrem";

            var students2 = new[] { "Ekrem", "Alpay" };
            string[] students3 = { "Ekrem", "Alpay" };

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            string[,] regions = new string[5, 3]
            {
                { "İstanbul","Kırklareli","Bursa"},
                { "Ankara","Konya","Kırıkkale"},
                { "Antalya","Adana","Mersin"},
                { "Trabzon","Rize","Artvin"},
                { "İzmir","Muğla","Manisa"}
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("*******************");
            }

            Console.ReadLine();
        }
    }
}