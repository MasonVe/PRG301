using System;

namespace NestedRepetition_Ex2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = "x";
            int counter = 1;
            int counter2 = 0;

            while (counter < 6)
            {

                while(counter2 != counter)
                {
                    Console.Write(type);
                    counter2++;
                }

                counter++;
                counter2 = 0;
                Console.WriteLine();

            }
        }
    }
}
