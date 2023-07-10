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

            IWordFrequencyAnalyzer wordFrequencyAnalyzer = new WordFrequencyAnalyzer();

            IDictionary<string, int> wordFrequencies = wordFrequencyAnalyzer.CountWordFrequencies(text);

            IGenerateTextDiagram diagramGenerator = new GenerateTextDiagram();
            string diagram = diagramGenerator.GenerateDiagram(wordFrequencies);

            Console.WriteLine(diagram);

            Console.ReadLine();
        }
    }
}
