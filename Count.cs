using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//accept 10 numbers in an array and find out how many times it will repeat and which number 
namespace ConsoleApp1
{
    internal class Count
    {
        public static void Test()
        {
            int[] numbers = new int[10];

            Console.WriteLine("Please enter 10 numbers:");

            for (int i = 0; i < 10; i++)
            {
                while (true)
                {
                    Console.Write("\nEnter number : ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out int num))
                    {
                        numbers[i] = num;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid input. Please enter an integer.");
                    }
                }
            }

            Dictionary<int, int> countDict = new Dictionary<int, int>();

            foreach (int num in numbers)
            {
                if (countDict.ContainsKey(num))
                {
                    countDict[num]++;
                }
                else
                {
                    countDict[num] = 1;
                }
            }

            // Print results
            Console.WriteLine("\nNumber of occurrences for each number:");
            foreach (var entry in countDict)
            {
                Console.WriteLine($"\nNumber {entry.Key} repeats {entry.Value} times.");
            }
        }
	public static void Main(string [] args)
	{
		Count.Test();
	}
    }
}
