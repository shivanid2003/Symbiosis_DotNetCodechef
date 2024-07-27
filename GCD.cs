//Program to Find GCD of 2 Numbers

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLab
{
    class GCD
    {
         public static void Test()
        {
            int num1, num2, gcd = 0;
            Console.WriteLine("Enter 1st integers: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd integers: ");
            num2 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num1 && i <= num2; i++)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    gcd = i;
                }
            }
            Console.WriteLine($"GCD of {num1} and {num2} is: {gcd}");
        }
	public static void Main(string [] args)
	{
		GCD.Test();
		Console.ReadLine();
	}
    }
}
