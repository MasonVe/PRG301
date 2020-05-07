 using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace FunctionsMethods
{
    class Program
    {
        static void Main(string[] args)
        /* TASK 1
    {

        {
            Console.Write("Enter 1: ");
            if (Console.ReadLine() == "1")
            {
                Greeting();
            }
            Console.ReadLine();

        }
    }
        public static void Greeting()
        {
            Console.WriteLine("Welcome Friends");
            Console.WriteLine("Have a nice day");
        }
        */




        /* TASK 2
        {
            string name;

            Console.Write("Enter Name: ");
            name = Console.ReadLine();

            welcome(); Console.WriteLine(name);
            
            day();

            Console.ReadLine();

        }

        public static void welcome()
        {
            Console.Write("Welcome friend ");
        }

        public static void day()
        {
            Console.Write("Have a nice day");
        }
        */

        /* TASK 3
        {
            int num1, num2;
            

            Console.Write("Enter a number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter another number: ");
            num2 = int.Parse(Console.ReadLine());

            int result = AddNumbers(num1, num2);
            Console.WriteLine("The sume of two numbers is: {0}", result);
            Console.ReadLine();
        }

        public static int AddNumbers(int number1, int number2)
        {
            int result = number1 + number2;
            return result;
        }
        */

        /* TASK 4
        {
            string input;
            Console.Write("Please Input A String: ");
            input = Console.ReadLine();

            Console.WriteLine("\""+ input + "\"" + " contains {0} spaces", counter(input));
            Console.ReadLine();
        }

        public static int counter(string str)
        {
            int c1 = 0;
            string s1;
            for (int i = 0; i < str.Length; i++)
            {
                s1 = str.Substring(i, 1);
                if (s1 == " ")
                    c1++;
            }
            return c1;
        }
        */

        /* TASK 5

        {
            int[] elements = new int[5];

            Console.WriteLine("Input 5 elements into aray:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter Value: ");
                elements[i] = int.Parse(Console.ReadLine());
            }
            int sum = elements.Sum();

            Console.WriteLine("The sum of the elements of that array is {0}", sum);
            Console.ReadLine();
        }
        */

        /* TASK 6
        {
            int n1;
            int n2;

            Console.Write("Enter a number: ");
            n1 = int.Parse(Console.ReadLine());


            Console.Write("Enter another numer: ");
            n2 = int.Parse(Console.ReadLine());

            swap(ref n1,ref n2);
            Console.WriteLine("Now the 1st number is: {0}, and the 2nd number is: {1}", n1,n2);
            Console.ReadLine();
        }

        public static void swap(ref int num1, ref int num2)
        {
            int num;
            num = num1;
            num1 = num2;
            num2 = num;
        }
        */

        /* TASK 7
        {
            int nbase = 0;
            int expo = 0;
            int answer = 0;


            Console.Write("Input Base Number: ");
            nbase = int.Parse(Console.ReadLine());


            Console.Write("Input Exponent: ");
            expo = int.Parse(Console.ReadLine());

            answer = powerto(nbase, expo);
            Console.WriteLine("So, the number {0}, to the power of {1} = {2}", nbase, expo, answer);
            Console.ReadLine();
        }

        public static int powerto(int nbase, int expo)
        {
            int value = 1;
            int i;
            for (i = 1; i <=expo; i++)
                value = value * nbase;
                return value;
            
        }
        */

        {

        }
    }
}
