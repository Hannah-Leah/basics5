using System.Diagnostics;

namespace CentralHeating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Radiator radiator = new Radiator();
            Heating heating = new Heating();


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Beep:");

            Console.ForegroundColor = ConsoleColor.Green;
            radiator.SwitchFlipped += heating.OnCallBack;
            radiator.press();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Boop:");

            Console.ForegroundColor = ConsoleColor.Yellow;
            radiator.press();
            radiator.SwitchFlipped += heating.OnCallBack;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Beep:");

            Console.ForegroundColor = ConsoleColor.Green;
            radiator.SwitchFlipped -= heating.OnCallBack;
            radiator.press();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Boop:");

            Console.ForegroundColor = ConsoleColor.Yellow;
            radiator.press();

        }
    }
}
