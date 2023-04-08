using CsharpAlgorithms.Exercises.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAlgorithms.Test.Exercises.Easy
{
    public class ValidParenthesesTest
    {
        [Fact]
        public void ValidParenthesesSuccess()
        {
            var parenthesesValidation = new ValidParentheseseExercise();
            var correctExample = "{[]}";

            var result = parenthesesValidation.IsValid(correctExample);

            Assert.Equal(result, true);
        }
    }
}
