using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//create the string array and find out how many vowels and consonents are present in that array

namespace ConsoleApp1
{
    internal class ArrayVC
    {
        public static void Test()
        {
            string[] stringArray = { "a", "b", "c", "d", "e" };

            int vowelCount = 0;
            int consonantCount = 0;

            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            foreach (string str in stringArray)
            {
                foreach (char ch in str.ToLower()) 
                { 
                    if (Char.IsLetter(ch))
                    {
                        if (Array.Exists(vowels, vowel => vowel == ch))
                        {
                            vowelCount++;
                        }
                        else
                        {
                            consonantCount++;
                        }
                    }
                }
            }
            Console.WriteLine($"Total vowels: {vowelCount}");
            Console.WriteLine($"Total consonants: {consonantCount}");
        }
	public static void Main(string [] args)
	{
		ArrayVC.Test();
	}
    }
}
