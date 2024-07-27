using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalLab
{
   internal class LeapYear
    {
        public static void Test()
        {
            Console.WriteLine("Enter a year to check if it's a leap year:");
            int year = Convert.ToInt32(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine($"{year} is a leap year");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year");
            }
            Console.ReadLine();
        }
	public static void Main(string [] args)
	{
		LeapYear.Test();
		Console.ReadLine();
	}
    }
}
