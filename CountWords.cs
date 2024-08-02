using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Accept the string and find out how many words are there in the string

namespace ConsoleApp1
{
    internal class CountWords
    {
        public static void Test()
        {
            static int CountWords(string input)
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    return 0;
                }

                string[] words = input.Split(new[] { ' ', '\t', '\n', '\r' });
                return words.Length;
            }

            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            // Find the number of words in the string
            int wordCount = CountWords(input);

            // Display the result
            Console.WriteLine($"The number of words in the string is: {wordCount}");
        }
	public static void Main(string [] args)
	{
		CountWords.Test();
	}
    }
}
