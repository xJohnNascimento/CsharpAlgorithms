using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAlgorithms.Exercises.Easy
{
    public class ValidParentheseseExercise
    {
        public bool IsValid(string s)
        {
            Stack<char> lifo = new Stack<char>();
            foreach(var item in s.ToCharArray())
            {
                if(item == '(')
                    lifo.Push(')');
                else if(item == '<')
                    lifo.Push('>');
                else if(item == '[')
                    lifo.Push(']');
                else if(item == '{')
                    lifo.Push('}');
                else if(lifo.Count == 0 || lifo.Pop() != item)
                    return false;
            }

            return lifo.Count == 0;
        }
    }
}
