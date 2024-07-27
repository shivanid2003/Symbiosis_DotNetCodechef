using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLab
{
    class BinaryTriangle
    {
        public static void Test()
        {
            Console.WriteLine("Enter the number of rows:");
            int rows = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write((i + j) % 2 + " ");
                }
                Console.WriteLine();
            }
        }
	public static void Main(string[] args)
        {
            
	    BinaryTriangle.Test();
            Console.ReadLine();
        }

    }
}
