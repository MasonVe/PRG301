using System;
using System.Collections.Generic;
using System.Text;

namespace Bingo
{
    public class Bingo
    {

        public void MainMenu()
        {
            Console.WriteLine("Welcome to the Swinburne Bingo Club");
            Console.WriteLine("1. Draw next number");
            Console.WriteLine("2. View all drawn numbers");
            Console.WriteLine("3. Check specific number");
            Console.WriteLine("4. Exit");
            Console.Write("Selection: ");


            int userSelection;
            string input = Console.ReadLine();
            
            if (int.TryParse(input, out userSelection))
            {
                switch (userSelection)
                {
                    case 1:
                        Numbers.Draw();
                        MainMenu();
                        break;

                    case 2:
                        Console.Clear();
                        ViewNumbers();
                        break;

                    case 3:
                        Console.Clear();
                        CheckNumber();
                        break;

                    case 4:
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("{0} is not a valid menu selection, please try again.", input);
                        Console.WriteLine("-------------------------------------------------------");
                        MainMenu();
                        break;

                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("{0} is not a valid menu selection, please try again.", input);
                Console.WriteLine("-------------------------------------------------------");
                MainMenu();
            }


        }

        public void ViewNumbers()
        {
            Console.WriteLine("View Numbers Menu");
            Console.WriteLine("1. Print All Numbers In Drawn Sequence");
            Console.WriteLine("2. Print All Numbers In Numerical Order");
            Console.WriteLine("3. Back");
            Console.Write("Selection: ");

            int userSelection;
            string input = Console.ReadLine();

            if (int.TryParse(input, out userSelection))
            {
                switch (userSelection)
                {
                    case 1:
                        Numbers.PrintSeq();
                        MainMenu();
                        break;

                    case 2:
                        Numbers.PrintOrder();
                        MainMenu();
                        break;

                    case 3:
                        Console.Clear();
                        MainMenu();
                        break;
                }
            }

        }

        public void CheckNumber()
        {
            Numbers.NumCheck();
        }

    }
}