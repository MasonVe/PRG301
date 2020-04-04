using System;

namespace NestedRepetition_Ex2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = "x";
            int counter = 1;
            int counter2 = 0;
            int desired = 0;

            Console.Write("Enter Desired Amount To Print: ");
            desired = int.Parse(Console.ReadLine());
            desired = (desired + 1);
            while (counter < desired)
            {

                while (counter2 != counter)
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