using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Bingo
{
    public class Numbers
    {

        public static int upperlimit;

        public static List<int> bingonum = new List<int>();


        public static void Draw()
        {
            Console.Clear();

            Random rand = new Random();


            int newnum = rand.Next(1, upperlimit);



            while (bingonum.Contains(newnum))
            {
                newnum = rand.Next(1, upperlimit);

            }

            bingonum.Add(newnum);

            Console.WriteLine("New Number: {0}", newnum);
            Console.WriteLine("---------------------");

        }


        
        public static void PrintSeq()
        {

            Console.Clear();
            var str = string.Join(", ", bingonum);
            Console.WriteLine("Your Numbers In Sequence Are: {0}", str);
            Console.WriteLine("------------------------------------------");


        }

        public static void PrintOrder()
        {
            Console.Clear();
            List<int> temp = bingonum.ToList();
            temp.Sort();
            var str = string.Join(", ", temp);
            Console.WriteLine("Your Numbers In Numerical Order Are: {0}", str);
            Console.WriteLine("------------------------------------------");
        }

        public static void NumCheck()
        {
            Console.WriteLine("Check Drawn Numbers");
            Console.WriteLine("Type 'menu' to return to main menu");
            Console.Write("Enter Number: ");
            string ii = Console.ReadLine();

            if (ii == "menu")
            {
                Console.Clear();
                new Bingo().MainMenu();

            }
            else
            {
                int input = int.Parse(ii);


                if (Numbers.bingonum.Contains(input) == true)
                {
                    Console.Clear();
                    Console.WriteLine("{0} has been drawn.", input);
                    Console.WriteLine("-----------------------------");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("{0} has not been drawn.", input);
                    Console.WriteLine("-----------------------------");
                }
                NumCheck();

            }



            
        
            
        }

    }
}
