using CsharpAlgorithms.SortAlgorithms;

namespace CsharpAlgorithms.Test.SortAlgorithms
{
    public class BubbleSortTest
    {
        [Fact]
        public void BubbleSort_Success()
        {
            int[] array = { 5, 4, 6, 8, 1, 2, 7, 3, 10, 9 };
            int[] sortedArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            BubbleSort sort = new BubbleSort();
            var result = sort.BubbleSortArray(array);

            Assert.True(result.SequenceEqual(sortedArray));
        }
    }
}
