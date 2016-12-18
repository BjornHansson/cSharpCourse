using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuplicateWordRemoval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter sentence (no punctuation): ");
            String sentence = Console.ReadLine();
            foreach (var word in GetUniqueWords(sentence))
            {
                Console.WriteLine(word);
            }
        }

        private static IEnumerable<String> GetUniqueWords(string sentence)
        {
            return (sentence ?? string.Empty)
                .Split()
                .Select(x => x.ToLowerInvariant())
                .Distinct()
                .OrderBy(x => x);
        }
    }
}
