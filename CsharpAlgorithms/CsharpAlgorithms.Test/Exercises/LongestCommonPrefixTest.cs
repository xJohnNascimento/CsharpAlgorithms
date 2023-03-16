using CsharpAlgorithms.Exercises.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAlgorithms.Test.Exercises
{
    public class LongestCommonPrefixTest
    {
        [Fact]
        public void LongestCommonPrefix_Success()
        {
            var longestCommonPrefix = new LongestCommonPrefixExercise();

            string[] strings = { "flower", "fl", "flight" };

            var result = longestCommonPrefix.LongestCommonPrefix(strings);

            Assert.Equal("fl", result);
        }
    }
}
