using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AnagramEx
    {
          public static void Test()
         {
            static bool AreAnagrams(string str1, string str2)
            {
                if (str1.Length != str2.Length)
                {
                    return false;
                }

                char[] arr1 = str1.ToCharArray();
                char[] arr2 = str2.ToCharArray();

                Array.Sort(arr1);
                Array.Sort(arr2);

                return new string(arr1) == new string(arr2);
            }

            // Accept two strings from the user
            Console.Write("Enter the first string: ");
            string firstString = Console.ReadLine();

            Console.Write("\nEnter the second string: ");
            string secondString = Console.ReadLine();

            // Check if the strings are anagrams
            bool isAnagram = AreAnagrams(firstString, secondString);

            // Output the result
            if (isAnagram)
            {
                Console.WriteLine($"\nThe {secondString} is an anagram of the {firstString}.");
            }
            else
            {
                Console.WriteLine($"\nThe {secondString} is not an anagram of the {firstString}.");
            }
         }
	public static void Main(string [] args)
	{
		AnagramEx.Test();
	}
    }
}
