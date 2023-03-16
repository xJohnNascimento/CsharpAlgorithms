using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAlgorithms.Exercises.Easy
{
    public class LongestCommonPrefixExercise
    {
        public string LongestCommonPrefix(string[] strs)
        {
            var result = "";
            int currentLetter = 0;

            if (strs.Length == 0 || strs[currentLetter].Length == 0)
            {
                return result;
            }

            char letter = strs[0][currentLetter];

            for(int i = 0; i < strs.Length; i++)
            {
                if (strs[i] == string.Empty || strs[i].Length - 1 < currentLetter)
                {
                    break;
                }

                if (strs[i][currentLetter] != letter)
                {
                    break;
                }

                if (i == strs.Length - 1)
                {
                    result += strs[i][currentLetter];

                    i = 0;
                    currentLetter++;

                    if (strs[i].Length - 1 < currentLetter)
                    {
                        break;
                    }
                    else
                    {
                        letter = strs[i][currentLetter];
                    }
                }
            }

            return result;
        }
    }
}
