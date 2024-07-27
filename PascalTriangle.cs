using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLab
{
    class PascalTriangle
    {
        public static void Test()
        {
            int n = 5; // You can change this value to print more rows

            for (int i = 0; i < n; i++)
            {
                for (int k = n; k > i; k--)
                {
                    Console.Write(" ");
                }

                int value = 1;
                for (int j = 0; j <= i; j++)
                {
                    Console.Write($"{value} ");
                    value = value * (i - j) / (j + 1);
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }
	public static void Main(string [] args)
	{
		PascalTriangle.Test();
		Console.ReadLine();
	}
    }
}
