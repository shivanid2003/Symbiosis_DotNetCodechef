using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLab
{
    class Diamand
    {
        public static void Test()
        {
            Console.WriteLine("Enter the number of rows for the diamond pattern:");
            int rows = int.Parse(Console.ReadLine());

            int n = rows / 2;

            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k < (i * 2); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = n; i >= 1; i--)
            { 
                for (int j = n; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k < (i * 2); k++)                          
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
	public static void Main(string [] args)
	{
		Diamand.Test();
		Console.ReadLine();
	}
    }
}
