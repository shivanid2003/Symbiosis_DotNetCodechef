using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLab
{
    class LCM
    {
        public static void Test()
        {
            int num1, num2, lcm;
            Console.WriteLine("Enter 1st integers: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd integers: ");
            num2 = int.Parse(Console.ReadLine());

            lcm = (num1 > num2) ? num1 : num2;

            while (true)
            {
                if (lcm % num1 == 0 && lcm % num2 == 0)
                {
                    Console.WriteLine($"LCM of {num1} and {num2} is: {lcm}");
                    break;
                }
                lcm++;
            }
        }
	public static void Main(string [] args)
	{
		LCM.Test();
		Console.ReadLine();
	}
    }
}
