using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Link<T1, T2>
    {
        /// <summary>
        /// <para data1, data2> is the data by which list will be filled in </para>
        /// </summary>
        private T1 data1;
        private T2 data2;
        /// <summary>
        /// <para next> referes to the next item in list </para>
        /// </summary>
        public Link<T1, T2> next;
        public Link(T1 dt1, T2 dt2)
        {
            data1 = dt1;
            data2 = dt2;
        }
        public void printLink()  //prints itself
        {
            Console.WriteLine("{" +data1 + ", " +data2 + "}");
        }
    }

    class LinkedList<T1,T2>
    {
        private Link<T1,T2> first;  // referes to first link in list
        public LinkedList ()
        {
            first = null;  //no items in list yet
        }
        public Boolean isEmpty ()
        {
            return (first == null);
        }
        public void insertFirst (T1 data1, T2 data2)  // insert new link at start of list
        {
            Link<T1, T2> newLink = new Link<T1, T2>(data1, data2);
            newLink.next = first;    // newLink --> old first 
            first = newLink;        // first --> newLink
        }
        public Link<T1, T2> deleteFirst ()  //delete first item in list
        {
            Link<T1, T2> deletedItem = first;
            first = first.next;
            return deletedItem;
        }
        public void displayList ()
        {
            Console.WriteLine("items in list: ");
            Link<T1, T2> current = first;
            while (current != null)
            {
                current.printLink();
                current = current.next;
            }
            Console.WriteLine();
        }
    }
}
