using System;
using System.Collections.Generic;

namespace Lists1
{
    class Program
    {
        static void Main(string[] args)


        {
            List<int> numbers = new List<int>();

            int dupe = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter Number: ");
                numbers.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.Write("Enter One More Number: ");
            dupe = int.Parse(Console.ReadLine());

            if (numbers.Contains(dupe))
            {
                Console.Write("{0} has already been entered!", dupe);
                Console.ReadLine();
            }
            else
            {
                Console.ReadLine();
            }
            
        }
    }
}
