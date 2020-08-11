using System;
using System.Security.Cryptography.X509Certificates;

namespace Bingo
{
    class Program
    {
        static void Main(string[] args)
        {

            void Start()
            {
                Console.WriteLine("Define Upper Limit of Numbers");
                Console.Write("Number: ");


                string input = Console.ReadLine();
                int num;

                if (int.TryParse(input, out num))
                {
                    Numbers.upperlimit = num;


                    if (num < 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Selection cannot be a negative number!");
                        Console.WriteLine("--------------------------------------");
                        Start();
                    }

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Selection can only be a number!");
                    Console.WriteLine("-------------------------------------------------");
                    Start();
                }

                
            }

            Start();

            Console.Clear();
            new Bingo().MainMenu();



        }
    }
}
