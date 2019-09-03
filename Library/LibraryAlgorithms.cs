using System;
using System.Collections.Generic;

namespace library
{
    public class LibraryAlgorithms
    {
        public int BinarySearch<T>(List<T> list,T item) where T : IComparable
        {
            int low = 0;
            int high = list.Count - 1;
            while (low <= high)
            {
                int mid = (low + high)/2;
                var guess = list[mid];
                if (guess.Equals(item)) return mid;
                if (guess.CompareTo(item) > 0 )  high = mid-1;
                else low = mid+1;
            }
            return -1;

        }
    }
}
