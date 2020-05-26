using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    static class Program
    {
        public static readonly int MaxValue = 100;
        
        /// Definitions of words
        /// Word is printed if modulo of the key is equal to 0
        private static readonly Dictionary<int, string> Words = new Dictionary<int, string>()
        {
            {3, "Fizz"},
            {5, "Buzz"},
        };
        
        static void Main()
        {
            // Temporary storage for words before they are printed to console
            List<string> values = new List<string>(Words.Count);
            
            // Start from 0 so you can see all the words on 1st line
            for (int i = 0; i <= MaxValue; i++)
            {
                foreach (var kvp in Words)
                    if (i % kvp.Key == 0)
                        values.Add(kvp.Value);

                if (values.Any())
                {
                    Console.WriteLine(string.Join(" ", values));
                    values.Clear();
                }
                else
                    Console.WriteLine(i);
            }
        }
    }
}