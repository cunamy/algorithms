using System;
using System.Collections.Generic;
using Xunit;
using library;

namespace tests
{
    public class UnitTestAlgorithms
    {
        [Fact]
        public void BinarySearchTest()
        {
            var library = new LibraryAlgorithms();
            var list = new List<int>{1,3,5,7,9};
            var result = library.BinarySearch<int>(list,2);
            Assert.Equal(result, -1);
            result = library.BinarySearch<int>(list,3);
            Assert.Equal(result, 1);
            
        }

        [Fact]
        public void FindSmallestTest()
        {
            var library = new LibraryAlgorithms();
            var list = new List<int>{6,3,5,1,9};
            var result = library.FindSmallest<int>(list);
            Assert.Equal(result, 3);            
        }

        [Fact]
        public void SelectionSortTest()
        {
            var library = new LibraryAlgorithms();
            var list = new List<int>{5,3,6,2,10};
            var result = library.SelectionSort<int>(list);
            Assert.Equal(new int[]{2,3,5,6,10},result.ToArray());            
        }

         [Fact]
        public void RecursiveSumTest()
        {
            var library = new LibraryAlgorithms();
            var list = new List<double>{5,3,6,2,10};
            var result = library.RecursiveSum(list);
            Assert.Equal(26,result);            
        }
    }
}
