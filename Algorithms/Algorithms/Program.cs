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
            /////<summary>
            ///// Binary Search testing.
            /////</summary>
            //Console.Write("Enter the item you are searching for: ");
            //int numberExistence, position;
            //String word;
            //int[] numbersList = { 1, 3, 5, 7, 9 };
            //String[] wordsList = { "Aa", "Bb", "Cc", "Dd", "Ee", "Ff", "Gg" };
            //numberExistence = int.Parse(Console.ReadLine());
            //position = SearchingAlgorithms<int>.Binary_Search(numbersList, numberExistence);
            //if (position == -1)
            //    Console.WriteLine("{0} not found in this list!", numberExistence);
            //else
            //{
            //    Console.WriteLine("{0} is found at index {1}", numberExistence, position);
            //}


            ////=============================================================================================

            /////<summary>
            ///// Stack testing.
            /////</summary>
            //string input;
            //Console.Write("Enter the string you want to reverse: ");
            //input = Console.ReadLine();
            //StackExample stk = new StackExample(input);
            //Console.WriteLine("Your string after reversing is: {0}", stk.Reverse());

            //=============================================================================================


            ///<summary>
            /// LinkedList testing.
            ///</summary>
            LinkedList<int, double> fillList = new LinkedList<int, double>();
            Link<int, double> deleteList;  //param used to store deleted links

            fillList.insertFirst(22, 2.99);  //filling the list
            fillList.insertFirst(44, 4.99);
            fillList.insertFirst(66, 6.99);
            fillList.insertFirst(88, 8.99);

            fillList.displayList();  //display list items after filling it

            while (!fillList.isEmpty())  //deleting list links
            {
                deleteList = fillList.deleteFirst();  //store deleted links to display them
                Console.Write("Deleted ");
                deleteList.printLink();  //print deleted link
            }

            Console.WriteLine();
            fillList.displayList();  //display list items after deleting it (no items will be found)
  

            //============================================================================================


        }
    }
}
