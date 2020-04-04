using System;

namespace Programming
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("What's your first name?");
            string firstname = Console.ReadLine();
            Console.WriteLine("What's your last name?");
            string lastname = Console.ReadLine();
            Console.WriteLine("Hello " + firstname + " " + lastname + "!");
            Console.ReadLine();
            
        }
    }
}
