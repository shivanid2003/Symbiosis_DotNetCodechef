using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//create an int array and find out max and min out of array 
//accepting single dia array from user and showing him min and maz no entered in the array

namespace ConsoleApp1
{
    internal class ArrayMinMax
    {
        public static void Test()
        {
            Console.Write("Enter the number of elements in the array: ");
            int size = int.Parse(Console.ReadLine());

            int[] numbers = new int[size];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write("Element : ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The elements in the array are:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            int max = numbers[0];
            int min = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            Console.WriteLine($"The minimum value in the array is: {min}");
            Console.WriteLine($"The maximum value in the array is: {max}");
        }
	public static void Main(string [] args)
	{
		ArrayMinMax.Test();
	}
    }
        
}

