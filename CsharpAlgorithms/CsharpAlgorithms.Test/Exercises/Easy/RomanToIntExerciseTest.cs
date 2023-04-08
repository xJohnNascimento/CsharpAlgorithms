using CsharpAlgorithms.Exercises.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAlgorithms.Test.Exercises.Easy
{
    public class RomanToIntExerciseTest
    {
        [Fact]
        public void RomanToInt_Success()
        {
            var romanToIntConverter = new RomanToIntExercise();

            var romanNumber = "XIX";

            var result = romanToIntConverter.RomanToInt(romanNumber);

            Assert.Equal(19, result);
        }
    }
}
