using System;

namespace NestedRepetition_Ex2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = "x";
            int counter = 0;
            int counter2 = 0;

            while (counter < 5)
            {
                counter2 = counter;

                while (counter2 < 5)
                {

                    Console.Write(type);
                    counter2++;
                }

                Console.WriteLine();

                counter++;

            }

            Console.ReadLine();
        }
    }
}