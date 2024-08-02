using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }
        public string Location { get; set; }
        public string Address { get; set; }

        public bool IsEligibleToVote()
        {
            return Age >= 18;
        }

    }
    public class AddList
    {
        public static void Test()
        {
            List<Person> people = new List<Person>();
            Console.Write("Enter the number of user: ");
            int num = int.Parse(Console.ReadLine());
            for(int i = 0; i < num; i++)
            {
                Person person = new Person();
                Console.WriteLine("Enter details for a new person:");

                Console.Write("Name: ");
                person.Name = Console.ReadLine();

                Console.Write("id: ");
                person.Id =Convert.ToInt32( Console.ReadLine());

                Console.Write("Age: ");
                person.Age = Convert.ToInt32(Console.ReadLine());

                Console.Write("location: ");
                person.Location = Console.ReadLine();

                Console.Write("Address: ");
                person.Address = Console.ReadLine();

                people.Add(person);
            }
            // Display the list of people
            Console.WriteLine("\n----Display the list of people----");
            foreach (Person p in people)
            {
                Console.WriteLine($"\n\t{p.Name}\t{p.Age}\t{p.Id}\t{p.Location}\t{p.Address}");
            }

            //Eligibility
            Console.WriteLine("\n----Display the persons who are eligible to vote----");
            static void EligibleVoters(List<Person> people)
            {
                var eligibleVoters = people.Where(p => p.IsEligibleToVote())
                                            .Select(p => new
                                            {
                                                p.Name,
                                                p.Age,
                                                p.Id,
                                                p.Location,
                                                p.Address
                                            });

                foreach (var person in eligibleVoters)
                {
                    Console.WriteLine($"\nName: {person.Name}, Age: {person.Age}, Id: {person.Id}, Location: {person.Location}, Address: {person.Address}");
                }
            }
            Console.WriteLine("\nEligible to Vote:");
            EligibleVoters(people);

            //Average Age
            Console.WriteLine("\nAverage Age:");
            static void AverageAge(List<Person> people)
            {
                if (people.Count == 0)
                {
                    Console.WriteLine("\nNo people in the list.");
                }

                double averageAge = people.Average(p => p.Age);
                Console.WriteLine($"\nAverage Age: {averageAge}");
            }
            Console.WriteLine("\nAverage Age:");
            AverageAge(people);

            static void NamesStartingWith(List<Person> people)
            {
                var namesStartingWithS = people.Where(p => p.Name.StartsWith("S", StringComparison.OrdinalIgnoreCase))
                                                .Select(p => new
                                                {
                                                    p.Name,
                                                    p.Age,
                                                    p.Id,
                                                    p.Location,
                                                    p.Address
                                                });

                foreach (var person in namesStartingWithS)
                {
                    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}, Id: {person.Id}, Location: {person.Location}, Address: {person.Address}");
                }
            }
            Console.WriteLine("Name Starts with S");
            NamesStartingWith(people);
        }
	public static void Main(string [] args)
	{
		AddList.Test();
	}
    }
}
