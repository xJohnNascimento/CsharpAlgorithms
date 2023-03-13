namespace CsharpAlgorithms.Exercises.Easy
{
    public class PalindromeNumberExercise
    {
        public bool IsPalindrome(int x)
        {
            int mod, sum = 0;
            int temp = x;
            while (x > 0)
            {
                mod = x % 10;
                sum = (sum * 10) + mod;
                x = x / 10;
            }

            if (temp == sum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
