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
        public int FindSmallest<T>(List<T> list) where T : IComparable
        {
            T min = list[0];
            int minIndex = 0;
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(min) < 0)
                {
                    minIndex = i;
                    min = list[i];
                }
            }
            return minIndex; 
        }

        public List<T> SelectionSort<T>(List<T> list)where T : IComparable
        {
            var newList = new List<T>();
            while(list.Count != 0)
            {
                var smallest = FindSmallest(list);
                newList.Add(list[smallest]);
                list.RemoveAt(smallest);
            }
            return newList;
        }

        public double   RecursiveSum(List<double> list) 
        {
            if (list.Count == 0) return 0;
            if (list.Count == 1) return list[0];
            return list[0] + RecursiveSum(list.GetRange(1,list.Count - 1 ));
        }
    }
}
