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
    }
}
