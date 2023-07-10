using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class GenerateTextDiagram : IGenerateTextDiagram
    {
        public string GenerateDiagram(IDictionary<string, int> wordFrequencies)
        {
            int maxFrequency = wordFrequencies.Values.Max();
            int maxWordLength = wordFrequencies.Keys.Max(w => w.Length);

            List<string> sortedWords = wordFrequencies.Keys.OrderBy(w => wordFrequencies[w]).ToList();

            string diagram = string.Empty;

            foreach (string word in sortedWords)
            {
                int frequency = wordFrequencies[word];
                int normalizedFrequency = (int)Math.Round((double)frequency / maxFrequency * 10);

                string wordColumn = word.PadLeft(maxWordLength, '_');
                string frequencyColumn = new string('.', normalizedFrequency).PadRight(10);

                diagram += $"{wordColumn} {frequencyColumn}\n";
            }

            return diagram;
        }
    }
}
