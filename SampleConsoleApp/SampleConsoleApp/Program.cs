using System;

namespace SampleConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                if (IsEven(number))
                {
                    Console.WriteLine($"{number} is Even.");
                }
                else
                {
                    Console.WriteLine($"{number} is Odd.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid integer.");
            }
        }

        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}
