using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChef
{
    class FindDuplicates
    {
        public static void Test()
        {
            int[] array = { 1, 2, 3, 4, 5, 5, 1, 6, 7};
            FindDuplicate(array);
        }

        public static void FindDuplicate(int[] array)
        {
            // Create a dictionary to store the count of each number
            Dictionary<int, int> counts = new Dictionary<int, int>();

            // Iterate through the array
            foreach (int number in array)
            {
                // If the number is already in the dictionary, increment its count
                if (counts.ContainsKey(number))
                {
                    counts[number]++; 
                }
            
                else
                {
                    // Otherwise, add the number to the dictionary with a count of 1
                    counts.Add(number, 1); 
                }
            }

            // Display the array
            Console.WriteLine("Array:. ");
            foreach (var arr in array)
            {
                Console.Write(arr);
            }
                  
            Console.WriteLine("\nDuplicates found:. ");
            // Iterate through the dictionary to find duplicates
            foreach (var pair in counts)
            {
                if (pair.Value > 1)
                {
                    Console.WriteLine($"{pair.Key} appears {pair.Value} times");
                }
            }
        }
	public static void Main(string[] args)
        {
            FindDuplicates.Test();

            Console.ReadKey();
        }
    }
}
