using System.Text;

namespace StringBuild
{
    internal class Program
    {
        static void Main(string[] args)
        {
           StringBuilder sb = new StringBuilder("Meow!");

            Console.WriteLine(sb.ToString());
            sb.Append("and woof!!");

            Console.WriteLine(sb.ToString());
        }
    }
}
