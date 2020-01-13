using System;

namespace lucky_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to find out if it is lucky: ");
            string input = Console.ReadLine();

            int.TryParse(input, out int num);
            Console.WriteLine(num.LuckyOrNot());

        }
    }

    public static class LuckyExtension
    {
        public static string LuckyOrNot(this int num)
        {
            if (num == 13 || num == 7)
            {
                return $"The number {num} is Lucky";
            }
            else
            {
                return $"The number {num} is NOT lucky";
            }
        }
    }
}
