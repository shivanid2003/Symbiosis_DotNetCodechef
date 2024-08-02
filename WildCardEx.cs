using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class WildCardEx
    {
        public static void Test()
        {
            Console.Write("Enter a string: ");
            string userInput = Console.ReadLine();

            bool containsWildcard = userInput.Contains('*') || userInput.Contains('?');

            if (containsWildcard)
            {
                Console.WriteLine($"The string contains wildcard character. {userInput}");
            }
            else
            {
                Console.WriteLine("The string does not contain any wildcard characters.");
            }
        }
	public static void Main(string [] args)
	{
		WildCardEx.Test();
	}
    }
}
