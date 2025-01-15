namespace FormatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float money = 1223.23333F;
            DateTime date = DateTime.Now;
            float value = 0.0002624F;

            Console.WriteLine(String.Format("{0:C}", money));
            Console.WriteLine(String.Format("{0:d}", date));
            Console.WriteLine(String.Format("{0:0.0000}", value));

            int temp = 0;
            string s1 = "österreich", s2 = "ÖSTERREICH";
            int erg = s1.CompareTo(s2);
            Console.WriteLine(erg);

            erg = string.Compare(s1, s2, StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine(erg);
        }
    }
}
