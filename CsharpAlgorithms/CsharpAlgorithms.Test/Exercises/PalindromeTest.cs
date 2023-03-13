using CsharpAlgorithms.Exercises.Easy;

namespace CsharpAlgorithms.Test.Exercises
{
    public class PalindromeTest
    {
        [Fact]
        public void IsPalindrome_Success()
        {
            var palindrome = new PalindromeNumberExercise();
            bool resultado = palindrome.IsPalindrome(121);

            Assert.True(resultado);
        }
    }
}
