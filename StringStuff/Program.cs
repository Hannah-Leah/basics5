using System.Text;
using System.Text.RegularExpressions;

namespace StringStuff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string meinString = "Hello\tWorld!";
            Console.WriteLine(meinString);

            string myString = "Hello\nWorld!";
            Console.WriteLine(myString);

            string myStringR = "HelloMyNameIs\rWorld!";
            Console.WriteLine(myStringR);

            string myStringUni = "\u0064";
            Console.WriteLine(myStringUni);

            Console.WriteLine("C:\\User\\Manuel\\Dokumente\\Noten.docx");
            Console.WriteLine(@"C:\User\Manuel\Dokumente\Noten.docx");
            Console.WriteLine(@"Hello there you lil b,
why are you readi ng this,
GO
AWAY
!!                        >:(");

            //-----------------String methods-----------------------------------------------

            string value = "Hello World!";
            Console.WriteLine(value.Replace("l", "x"));
            Console.WriteLine(value.Replace("Hello", "Goodbye"));

            Console.WriteLine(value.Contains("hello", StringComparison.CurrentCultureIgnoreCase));

            Console.WriteLine(value.Insert(6, "Wubba"));
            string[] erg = value.Split(' ');
            Console.WriteLine("wait");

            //-----------------Format Strings-----------------------------------------------

            float money = 1223.23333F;
            DateTime date = DateTime.Now;
            float value2 = 0.0002624F;

            Console.WriteLine(String.Format("{0:C}", money));
            Console.WriteLine(String.Format("{0:d}", date));
            Console.WriteLine(String.Format("{0:0.0000}", value2));

            string s1 = "österreich", s2 = "ÖSTERREICH";
            int erg2 = s1.CompareTo(s2);
            Console.WriteLine(erg2);

            erg2 = string.Compare(s1, s2, StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine(erg2);

            //-----------------String Builder-----------------------------------------------

            StringBuilder sb = new StringBuilder("Meow!");
            Console.WriteLine(sb.ToString());

            sb.Append("and woof!!");
            Console.WriteLine(sb.ToString());

            //----------------- Regex -----------------------------------------------

            Console.WriteLine("Give me your password!! \n Minimum eight characters, at least one upper case English letter, one lower case English letter, one number and one special character: ");

            string myValue = Console.ReadLine();
            string regexPattern = @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$ %^&*-]).{8,}$";

            if (Regex.IsMatch(myValue, regexPattern))
            {
                Console.WriteLine("ok");
            }
            else
            {
                Console.WriteLine("not ok");
            }

            Console.WriteLine("Now give me your username! \n lower and upper case letters are allowed, only letters, maximal length 25 letters");
            string valueUsername = Console.ReadLine();

            string RegexExpression = @"^[A-Za-z]{1,25}$";

            if (Regex.IsMatch(valueUsername, RegexExpression))
            {
                Console.WriteLine("okie dokie");
            }
            else
            {
                Console.WriteLine("not okie dokie");
            }

        }
    }
}
