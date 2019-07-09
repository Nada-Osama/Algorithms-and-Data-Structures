using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Stack<T>
    {
        int size, top;
        T[] stackArray;
        public Stack(int size)
        {
            this.size = size;
            stackArray = new T[size];
            top = -1;  //This position indicates that initially the stack is empty.
        }
        public void Push (T item)
        {
            stackArray[++top] = item;
        }
        public T Pop ()
        {
            return stackArray[top--];
        }
        public T Peek()  // returns the value at top, without changing the stack. 
        {
            return stackArray[top];
        }
        public Boolean isEmpty()  //returns true if stack is empty.
        {
            return (top == -1);
        }
        public Boolean isFull()  //returns true if stack is full.
        {
            return (top == size-1);
        }
    }
}
