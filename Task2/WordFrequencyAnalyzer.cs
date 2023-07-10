using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class WordFrequencyAnalyzer : IWordFrequencyAnalyzer
    {
        public Dictionary<string, int> CountWordFrequencies(string[] text)
        {
            Dictionary<string, int> frequencies = new Dictionary<string, int>();

            foreach (string word in text)
            {
                if (frequencies.ContainsKey(word))
                    frequencies[word]++;
                else
                    frequencies[word] = 1;
            }

            return frequencies;
        }
    }
}
