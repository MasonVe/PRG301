using System;

namespace Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];
            

            for (int i = 0; i < names.Length; i++)
            {
                Console.Write("Enter Name: ");
                names[i] = Console.ReadLine();
            }

            for (int i = 0; i < names.Length; i++)
            {
                Console.Write("Hello {0}. ", names[i]);
            }
            Console.ReadLine();
        }
    }
}
