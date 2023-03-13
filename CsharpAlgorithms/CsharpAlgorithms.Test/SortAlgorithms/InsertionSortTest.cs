using CsharpAlgorithms.SortAlgorithms;

namespace CsharpAlgorithms.Test.SortAlgorithms
{
    public class InsertionSortTest
    {
        [Fact]
        public void InsertionSort_Success()
        {
            int[] array = { 5, 4, 6, 8, 1, 2, 7, 3, 10, 9 };
            int[] sortedArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            InsertionSort sort = new InsertionSort();
            var result = sort.InsertionSortArray(array);

            Assert.True(result.SequenceEqual(sortedArray));
        }
    }
}