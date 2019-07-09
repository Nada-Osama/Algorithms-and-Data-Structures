using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class StackExample
    {
        ///<summary>
        ///   Reversing a Word
        /// Because of its Last-In-First-Out characteristic, the stack reverses the order of the characters.
        ///</summary>
        String input, output = "";
        Stack<char> stackInput;
        public StackExample (String input)
        {
            this.input = input;
        }
        public String Reverse ()
        {
            stackInput = new Stack<char>(input.Length);
            for (int i = 0; i < input.Length; ++i)
            {
                stackInput.Push(input[i]);
            }
            while (!stackInput.isEmpty())
            {
                output += (stackInput.Pop());
            }
            return output;
        }
    }
}
