namespace Strings
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Intro();

            string sentence = "My name is Ekrem Alpay";
            var resultLength = sentence.Length;
            var resultClone = sentence.Clone();
            var resultEndWith = sentence.EndsWith("y");
            var resultStartsWith = sentence.StartsWith("M");
            var resultIndexOf = sentence.IndexOf("name", StringComparison.Ordinal);
            var resultLastIndexOf = sentence.LastIndexOf(" ", StringComparison.Ordinal);
            var resultInesrt = sentence.Insert(0, "Hello, ");
            var resultSubstring1 = sentence.Substring(3);
            var resultSubstring2 = sentence.Substring(3, 4);
            var resultToLower = sentence.ToLower();
            var resultToUpper = sentence.ToUpper();
            var resultReplace = sentence.Replace(" ", "-");
            var resultRemove1 = sentence.Remove(3);
            var resultRemove2 = sentence.Remove(3, 4);

            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Istanbul";
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "Ankara";
            string result = city + " - " + city2;

            Console.WriteLine(result);
            Console.WriteLine(string.Format($"{city} {city2}"));
        }
    }
}