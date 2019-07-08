using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class SearchingAlgorithms<T>
    {
        public static int Binary_Search (T[] list, T item)
        {
            Comparer<T> comparer = Comparer<T>.Default;
            int mid, low = 0, high = list.Length - 1;
            while (low <= high)
            {
                mid = (low + high) / 2;
                if (comparer.Compare(list[mid], item) == 0)
                    return mid;
                if (comparer.Compare(list[mid], item) > 0)
                    high = mid - 1;
                else
                    low = mid + 1;
            }
            return -1;
        }
    }
}
