using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace BeeKeeper
{
    public class Menu
    {
        Bee b1 = new Bee("John", 3.2f);
        Bee b2 = new Bee("Paul", 2.7f);
        Bee b3 = new Bee("George", 1.1f);
        Bee b4 = new Bee("Ringo", 2.0f);
        Bee b5 = new Bee("Kurt", 2.3f);
        Bee b6 = new Bee("Dave", 7.4f);
        Bee b7 = new Bee("Krist", 1.5f);

        Hive bh1 = new Hive();
        Hive bh2 = new Hive();

        
        public void MainMenu()
        {

            Console.WriteLine("Welcome To Bee Keeper");
            Console.WriteLine("1. Create Bee Hive");
            Console.WriteLine("2. Collect Honey");
            Console.WriteLine("3. Bee Report");
            Console.WriteLine("4. Exit");
            Console.WriteLine("");
            Console.Write("Selection: ");

            
            string userSelection = Console.ReadLine();

            switch (userSelection)
            {
                case "1":
                    Console.Clear();
                    CreateHive();
                    break;

                case "2":
                    Console.Clear();
                    Honey();
                    break;

                case "3":
                    Console.Clear();
                    Report();
                    break;

                case "4":
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Please select an option from the menu!");
                    MainMenu();
                    break;
            }

        }

        public void CreateHive()
        {

            if (Hive.maxhive == 2)
            {
                Console.Clear();
                Console.WriteLine("Two Bee Hives is enough for now!");
                Console.WriteLine("--------------------------------");
                MainMenu();
            }
           else
            {
                if (bh1.beelist.Count == 0)
                {
                    Console.Write("Enter name of hive: ");
                    string tempname = Console.ReadLine();

                    bh1.name = tempname;
                    bh1.AddBee(b1);
                    bh1.AddBee(b2);
                    bh1.AddBee(b3);
                    bh1.AddBee(b4);


                    Hive.maxhive++;
                    Console.Clear();
                    Console.WriteLine("The Bee Hive \"{0}\" has been created!", bh1.name);
                    MainMenu();

                }
                else
                {
                    Console.Write("Enter name of hive: ");
                    string tempname = Console.ReadLine();

                    bh2.name = tempname;
                    bh2.AddBee(b5);
                    bh2.AddBee(b6);
                    bh2.AddBee(b7);

                    Hive.maxhive++;
                    Console.Clear();
                    Console.WriteLine("The Bee Hive \"{0}\" has been created!", bh2.name);
                    MainMenu();
                }
                


            }
        }

        public void Honey()
        {
            Console.WriteLine("Choose a bee hive: ");
            Console.WriteLine("\"{0}\" or \"{1}\"", bh1.name, bh2.name);
            Console.WriteLine();
            Console.Write("Selection: ");
            string choice = Console.ReadLine();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("How many days would you like to collect honey for?");
            Console.Write("Selection: ");
            int day = int.Parse(Console.ReadLine());
            if (choice == bh1.name)
            {
                Console.Clear();
                Console.Write("{0} ", bh1.name);
                bh1.CollectHoney(day);
                Console.WriteLine("---------------------------------------------");
                MainMenu();
            }
            else
            {
                Console.Clear();
                Console.Write("{0} ", bh2.name);
                bh2.CollectHoney(day);
                Console.WriteLine("----------------------------------------------");
                MainMenu();
            }

        }

        public void Report()
        {
            if (bh2.name == "")
            {
                Console.WriteLine("There are no bees!");
                Console.WriteLine("-------------------------------");
                MainMenu();
            }
            else
            {
                Console.WriteLine("Select a hive: ");
                Console.WriteLine("{0}", bh1.name);
                Console.WriteLine("{0}", bh2.name);
                Console.Write("Selection: ");
                string selection = (Console.ReadLine());

                if (selection == bh1.name)
                {
                    Console.Clear();
                    Console.WriteLine("There are {0} bees in bee hive \"{1}\"", bh1.beelist.Count, bh1.name);
                    Console.WriteLine("----------------------------------------------------");
                    MainMenu();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("There are {0} bees in bee hive \"{1}\"", bh2.beelist.Count, bh2.name);
                    Console.WriteLine("----------------------------------------------------");
                    MainMenu();
                }

            }
        }
    }
}
