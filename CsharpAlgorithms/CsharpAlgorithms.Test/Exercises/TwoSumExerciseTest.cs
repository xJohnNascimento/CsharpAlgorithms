using CsharpAlgorithms.Exercises.Easy;

namespace CsharpAlgorithms.Test.Exercises
{
    public class TwoSumExerciseTest
    {
        [Fact]
        public void TwoSumExercise_Success()
        {
            var twoSum = new TwoSumExercise();
            int[] values = { 1, 4, 5 };
            int target = 6;

            int[] result = twoSum.TwoSum(values, target);

            Assert.Equal(2, result.Length);
            Assert.Equal(values[result[0]] + values[result[1]], target);
        }
    }
}
