using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpAlgorithms.SortAlgorithms;

namespace CsharpAlgorithms.Test.SortAlgorithms
{
    public class BubbleSortTest
    {
        [Fact]
        public void Test1()
        {
            int[] array = { 5, 4, 6, 8, 1, 2, 7, 3, 10, 9 };
            int[] sortedArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            BubbleSort sort = new BubbleSort();
            var result = sort.BubbleSortArray(array);

            Assert.True(result.SequenceEqual(sortedArray));
        }
    }
}
