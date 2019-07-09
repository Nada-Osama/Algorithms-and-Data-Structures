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
            ///<summary>
            /// Binary Search testing.
            ///</summary>
            Console.Write("Enter the item you are searching for: ");
            int numberExistence, position;
            String word;
            int[] numbersList = { 1, 3, 5, 7, 9 };
            String[] wordsList = { "Aa", "Bb", "Cc", "Dd", "Ee", "Ff", "Gg" };
            numberExistence = int.Parse(Console.ReadLine());
            position = SearchingAlgorithms<int>.Binary_Search(numbersList, numberExistence);
            if (position == -1)
                Console.WriteLine("{0} not found in this list!", numberExistence);
            else
            {
                Console.WriteLine("{0} is found at index {1}", numberExistence, position);
            }

            //=============================================================================================

            ///<summary>
            /// Stack testing.
            ///</summary>
            string input;
            Console.Write("Enter the string you want to reverse: ");
            input = Console.ReadLine();
            StackExample stk = new StackExample(input);
            Console.WriteLine("Your string after reversing is: {0}", stk.Reverse());

        }
    }
}
