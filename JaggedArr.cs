using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class JaggedArr
    {
        public static void Test()
        {
            int[][] arr = new int[2][];  

            arr[0] = new int[] { 11, 21, 56, 78 };         
            arr[1] = new int[] { 42, 61, 37, 41, 59, 63 };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(j + " " + arr[i][j]);  
                }
                Console.WriteLine();
            }
        }
	public static void Main(string [] args)
	{
		JaggedArr.Test();
	}
    }
}
