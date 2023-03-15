namespace CsharpAlgorithms.Exercises.Easy
{
    public class RomanToIntExercise
    {
        public int RomanToInt(string s)
        {
            int result = 0;

            var romanNumbersDictionary = new Dictionary<char, int>()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            for (int i = 0; i < s.Length; i++)
            {
                char currentChar = s[i];
                romanNumbersDictionary.TryGetValue(currentChar, out int num);
                if (i + 1 < s.Length && romanNumbersDictionary[s[i + 1]] > romanNumbersDictionary[currentChar])
                {
                    result -= num;
                }
                else
                {
                    result += num;
                }
            }

            return result;
        }
    }
}
