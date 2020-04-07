using System;
using System.Collections.Generic;

namespace Lists3
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> words = new List<string>();


            while(true)
            {
                Console.Write("Enter Word: ");
                string input = Console.ReadLine();
                words.Add(input);

                if(input == "stop")
                {
                    break;
                }
            }

            words.ForEach(Console.WriteLine);
            Console.ReadLine();

        }
    }
}
