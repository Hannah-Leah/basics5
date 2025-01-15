using System.Net.Security;

namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value = "Hello World!";
            Console.WriteLine(value.Replace("l", "x"));
            Console.WriteLine(value.Replace("Hello", "Goodbye"));

            Console.WriteLine(value.Contains("hello", StringComparison.CurrentCultureIgnoreCase));

            Console.WriteLine(value.Insert(6, "Wubba"));
            string[] erg = value.Split(' ');
            Console.WriteLine("wait");

           

        }
    }
}
