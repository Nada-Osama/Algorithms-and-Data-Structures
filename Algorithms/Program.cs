using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the item you are searching for: ");
            int numberExistence;
            String word;
            String[] wordsList = { "name", "judgment", "office", "box", "fire" };
            int[] numbersList = { 1, 3, 5, 7, 9 };
            Array.Sort(wordsList);
            Array.Sort(numbersList);
            word = Console.ReadLine();
            Console.WriteLine(SearchingAlgorithms<String>.Binary_Search(wordsList, word));
        }
    }
}
