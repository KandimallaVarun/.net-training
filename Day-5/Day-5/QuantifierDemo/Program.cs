using System;
using System.Linq;

namespace QuantifierDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            int[] score = { 11, 44, 55, 66, 77 };

            Console.WriteLine("===== ELEMENT OPERATORS =====");

            // ElementAt()
            Console.WriteLine("ElementAt(2) : " + score.ElementAt(2));

            // ElementAtOrDefault()
            Console.WriteLine("ElementAtOrDefault(10) : " + score.ElementAtOrDefault(10));

            // First()
            Console.WriteLine("First() : " + score.First());

            // FirstOrDefault()
            Console.WriteLine("FirstOrDefault() : " + score.FirstOrDefault());

            // First(predicate)
            Console.WriteLine("First(x > 50) : " + score.First(x => x > 50));

            // FirstOrDefault(predicate)
            Console.WriteLine("FirstOrDefault(x > 100) : " + score.FirstOrDefault(x => x > 100));

            // Single()
            Console.WriteLine("Single(x == 44) : " + score.Single(x => x == 44));

            // SingleOrDefault()
            Console.WriteLine("SingleOrDefault(x == 55) : " + score.SingleOrDefault(x => x == 55));

            // Last()
            Console.WriteLine("Last() : " + score.Last());

            // LastOrDefault()
            Console.WriteLine("LastOrDefault() : " + score.LastOrDefault());

            Console.WriteLine();
            Console.WriteLine("===== QUANTIFIER OPERATORS =====");

            // Any()
            Console.WriteLine("Any() : " + score.Any());

            // Any(predicate)
            Console.WriteLine("Any(x > 70) : " + score.Any(x => x > 70));

            // All()
            Console.WriteLine("All(x > 10) : " + score.All(x => x > 10));

            Console.WriteLine("All(x > 50) : " + score.All(x => x > 50));

            // Contains()
            Console.WriteLine("Contains(44) : " + score.Contains(44));

            Console.WriteLine("Contains(100) : " + score.Contains(100));

            Console.ReadKey();
        }
    }
}