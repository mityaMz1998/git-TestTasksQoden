using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    class Task2
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> wordFrequencies = CountWordFrequencies(text);
            List<KeyValuePair<string, int>> sortedFrequencies = SortFrequencies(wordFrequencies);

            int maxFrequency = 0;
            foreach (var i in sortedFrequencies)
            {
                if (maxFrequency < i.Value)
                    maxFrequency = i.Value;
            }

            int maxBarWidth = 10;

            foreach (KeyValuePair<string, int> pair in sortedFrequencies)
            {
                string word = pair.Key;
                int frequency = pair.Value;

                string bar = GenerateFrequencyBar(frequency, maxFrequency, maxBarWidth);
                Console.WriteLine("{0} {1}", word.PadLeft(GetMaxWordLength(sortedFrequencies), '_'), bar);
            }
            Console.ReadLine();
        }

        static Dictionary<string, int> CountWordFrequencies(string[] text)
        {
            Dictionary<string, int> frequencies = new Dictionary<string, int>();

            foreach (string word in text)
            {
                if (frequencies.ContainsKey(word))
                {
                    frequencies[word]++;
                }
                else
                {
                    frequencies[word] = 1;
                }
            }

            return frequencies;
        }

        static List<KeyValuePair<string, int>> SortFrequencies(Dictionary<string, int> frequencies)
        {
            return frequencies.OrderBy(x => x.Value).ToList();
        }

        static string GenerateFrequencyBar(int frequency, int maxFrequency, int maxBarWidth)
        {
            int barLength = (int)Math.Round((double)frequency / maxFrequency * maxBarWidth);

            return new string('.', barLength).PadRight(maxBarWidth);
        }

        static int GetMaxWordLength(List<KeyValuePair<string, int>> frequencies)
        {
            return frequencies.Max(x => x.Key.Length);
        }
    }
}
