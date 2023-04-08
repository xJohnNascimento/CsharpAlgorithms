using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAlgorithms.Exercises.Medium
{
    public class LongestSubstringWithoutRepeatingCharactersExercise
    {
        public long LongestSubstringWithoutRepeatingCharacters(string s) 
        {
            if (s == string.Empty || s == null)
            {
                return 0;
            }

            HashSet<char> characters = new HashSet<char>();
            int longestSubstring = 0;
            int count = 0;
            int current = 0;
            int startAt = 0;

            while(startAt < s.Length)
            {
                if (characters.Contains(s[current]))
                {
                    characters.Clear();

                    if(count > longestSubstring) 
                    {
                        longestSubstring = count;
                    }

                    count = 0;
                    current = startAt = startAt + 1;
                }
                else
                {
                    characters.Add(s[current]);
                    current++;
                    count++;

                    if (current >= s.Length)
                    {
                        break;
                    }
                }
            }
            return Math.Max(longestSubstring, count);
        }
    }
}
