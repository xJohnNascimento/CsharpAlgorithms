using CsharpAlgorithms.Exercises.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAlgorithms.Test.Exercises.Medium
{
    public class LongestSubstringWithoutRepeatingCharactersTest
    {
        [Fact]
        public void LongestSubstringWithoutRepeatingCharacters_Success()
        {
            var longestSubstring = new LongestSubstringWithoutRepeatingCharactersExercise();

            var result = longestSubstring.LongestSubstringWithoutRepeatingCharacters("pwwkew");

            Assert.Equal(3, result);
        }
    }
}
