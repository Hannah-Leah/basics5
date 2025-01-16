namespace DelegateFilter
{

    // delegate is a prototype of a method
    delegate bool IntFilter(int a);

     
    internal class Program
    {
        // allgemeine Funktion schreiben
        // die werte filtert
        // ohne ein spezifischen Filter anzugeben

        /// <summary>
        /// 
        /// </summary>
        /// <param name="zahlen"></param>
        /// <param name="text"></param>
        /// <param name="filter">Delegate return bool, gets one int</param>
        static void FilterDelegate(int[] zahlen, string text, IntFilter filter)
        {
            Console.WriteLine(text);
            foreach (int i in zahlen)
            {
                if(filter(i))
                {
                    Console.WriteLine($"{i} ");
                }
            }
            Console.WriteLine();
        }

        // Methode für das Delegate 

        static bool Gerade(int zahl)
        {
            return zahl % 2 == 0;
        }
        static bool Unter100(int zahl)
        {
            Console.WriteLine("C");
            if (zahl < 100)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            int[] zahlen = new int[] { 1, 202, 2, 3, 4, 9, 12, 176, };
            //volles delegate mit allgemeiner Funktion
            FilterDelegate(zahlen, "Gerade zahlen:", Gerade);
            FilterDelegate(zahlen, "Unter 100:", Unter100);

            // anonyme Methode

            IntFilter over70 = delegate (int zahl) { return zahl > 70; };

            FilterDelegate(zahlen, "über 70", over70);

            FilterDelegate(zahlen, "Ungerade:", delegate(int zahl) { return !(zahl % 2 == 0); });

            // Lambda Methode

            FilterDelegate(zahlen, "under 50", z => z < 50);
        }
    }
}
