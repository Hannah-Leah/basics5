using System.Diagnostics;

namespace basics5
{
    internal class Program
    {

        class Test : IComparable<Test>  
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public static bool SortByName { get; set; } = false;

            /// <summary>
            ///  Wenn true wird nach Namen sortiert, am sonst nach ID
            /// </summary>

            public int CompareTo(Test? other)
            {

                if (SortByName)
                {
                    return this.Name.CompareTo(other.Name);
                } else
                {
                    return this.ID.CompareTo(other.ID);
                }

                // Sortieren nach ID

                // Sortieren anhand fertiger Methode
                //  return this.ID.CompareTo(other.ID);

                // Händisch Sortieren 
              /*  if (this.ID < other.ID)
                {
                    return -1;
                }
                else if (this.ID > other.ID)
                {
                    return 1;
                }
                else
                {
                    return 0;  
                }
              */

                // Sortieren nach Namen
              //  return Name.CompareTo(other.Name);

            }
        }
        static void Main(string[] args)
        {

            // Compare Interfaces 

            int[] myArray = new int[10];
            int[] mySecArray = new int[10];

            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {

                myArray[i] = rnd.Next(1, 100);
            }

            myArray.CopyTo(mySecArray, 0);
            /*
            Output(myArray, mySecArray);
            Array.Sort(myArray);
            Output(myArray, mySecArray);
            foreach (int i in myArray)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();

            foreach (int i in mySecArray)
            {
                Console.WriteLine(i + " ");
            }

            Console.WriteLine();

            Array.Sort(myArray);

        }
            */

            // Array mit custom objekten 
            Test[] myobjArr = new Test[3];
            myobjArr[0] = new Test() { ID = 532, Name = "Max" };
            myobjArr[1] = new Test() { ID = 54, Name = "Cate" };
            myobjArr[2] = new Test() { ID = 85, Name = "Lucy" };

            foreach (Test obj in myobjArr)
            {
                Console.WriteLine(obj.Name + " " + obj.ID);
            }
            Test.SortByName = true;
            Array.Sort(myobjArr);

            foreach (Test obj in myobjArr)
            {
                Console.WriteLine(obj.Name + " " + obj.ID);
            }


            static void Output(int[] arr, int[] secarr) {

                foreach (int i in arr)
                {
                    Console.WriteLine( i + " ");
                }
                Console.WriteLine();
                foreach( int i in secarr)
                {
                    Console.WriteLine(i + " ");
                }
                Console.WriteLine();
    
        }
        }
    }
}

