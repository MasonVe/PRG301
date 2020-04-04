using System;

namespace NestedRepetition_Ex2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = "x";
            int counter = 0;
            int counter2 = 0;
            int input = 0;

            Console.Write("Enter Starting X Amount: ");
            input = int.Parse(Console.ReadLine());

            while (counter < input)
            {
                counter2 = counter;

                while (counter2 < input)
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