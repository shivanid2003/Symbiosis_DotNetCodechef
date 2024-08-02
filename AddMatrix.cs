using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//addition of 2d matrix

namespace ConsoleApp1
{
    internal class AddMatrix
    {
        public static void Test()
        {
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            int cols = int.Parse(Console.ReadLine());

            int[,] matrixA = new int[rows, cols];
            int[,] matrixB = new int[rows, cols];
            int[,] resultMatrix = new int[rows, cols];

            Console.WriteLine("\nEnter values for Matrix A:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"\nMatrix A[{i},{j}] = ");
                    matrixA[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nEnter values for Matrix B:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"\nMatrix B[{i},{j}] = ");
                    matrixB[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    resultMatrix[i, j] = matrixA[i, j] + matrixB[i, j];
                }
            }

            Console.WriteLine("\nResulting Matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(resultMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
	public static void main(string [] args)
	{
		AddMatrix.Test();
	}
    }
}
