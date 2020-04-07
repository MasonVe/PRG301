using System;

namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 34, 5, 67, 1, 99, 34, 44, 78, 34, 0 };

            int sum = 0;

            for (int i=0; i < values.Length; i++)
            {
                sum += values[i];
            }

            Console.Write("Sum of All Array Items: {0}", sum);
            Console.ReadLine();
        }
    }
}
