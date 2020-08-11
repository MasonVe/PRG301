using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Menu();
        }

        static void Menu()
        {

            if (Person.count == 0)
            {
                int temp6 = 0;

                Console.Write("Enter Room Number: ");
                string temp1 = Console.ReadLine();
                Console.Write("Enter Name: ");
                string temp2 = Console.ReadLine();
                Console.Write("Enter Date Entered: ");
                string temp3 = Console.ReadLine();
                Console.Write("Enter Time Entered: ");
                string temp4 = Console.ReadLine();
                Console.Write("Total Time Stayed: ");
                string temp5 = Console.ReadLine();

                try
                {
                    temp6 = int.Parse(temp5);

                    if (temp6 < 0)
                    {
                        throw new Exception();
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Input not an integer :( - {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Time traveler? {ex.Message}");
                }
                finally
                {
                    //
                }

                Person p1 = new Person(temp1, temp2, temp3, temp4, temp6);
                Person.count++;
                Console.WriteLine("------------------------");
                Menu();

            }

            else
            {
                if (Person.count > 2)
                {
                    Console.WriteLine("Two entries already exist!");
                    System.Environment.Exit(1);
                }
                else
                {

                    int temp6 = 0;

                    Console.Write("Enter Room Number: ");
                    string temp1 = Console.ReadLine();
                    Console.Write("Enter Name: ");
                    string temp2 = Console.ReadLine();
                    Console.Write("Enter Date Entered: ");
                    string temp3 = Console.ReadLine();
                    Console.Write("Enter Time Entered: ");
                    string temp4 = Console.ReadLine();
                    Console.Write("Total Time Stayed: ");
                    string temp5 = Console.ReadLine();

                    try
                    {
                        temp6 = int.Parse(temp5);

                        if (temp6 < 0)
                        {
                            throw new Exception();
                        }
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine($"Input not an integer :( - {ex.Message}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Time traveler? {ex.Message}");
                    }
                    finally
                    {
                        //
                    }

                    Person p2 = new Person(temp1, temp2, temp3, temp4, temp6);
                    Person.count++;
                    Menu();

                }
                
            }
            
           
        }
    }




    public class Person
    {
        public static int count = 0;
        public string room = "";
        public string name = "";
        public string entrydate = "";
        public string entrytime = "";
        public int timestayed = 0;


        public Person(string room, string name, string date, string time, int staytime)
        {
            this.room = room;
            this.name = name;
            this.entrydate = date;
            this.entrytime = time;
            this.timestayed = staytime;
        }
    }
}
