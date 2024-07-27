using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLab
{
    class Armstrong
    {
        public static void Test()
        {
            Console.WriteLine("Enter a number to check if it is an Armstrong number:");
            int number = int.Parse(Console.ReadLine());

            if (IsArmstrong(number))
            {
                Console.WriteLine($"{number} is an Armstrong number.");
            }
            else
            {
                Console.WriteLine($"{number} is not an Armstrong number.");
            }
        }

        static bool IsArmstrong(int number)
        {
            int sum = 0, temp = number;
            int digits = number.ToString().Length;

            while (temp != 0)
            {
                int remainder = temp % 10;
                sum += (int)Math.Pow(remainder, digits);
                temp /= 10;
            }

            return sum == number;
        }
	public static void Main(string[] args)
        {
            Armstrong.Test();

            Console.ReadLine();
        }

    }
}
