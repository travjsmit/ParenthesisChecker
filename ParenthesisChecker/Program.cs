using System;
using System.Collections;

namespace ParenthesisChecker
{
    public class Program
    {
        public static bool IsBalanced(string expression)
        {
            Stack stack = new Stack();
            foreach (char c in expression)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    char top = (char)stack.Pop();
                    if (!IsMatchingPair(top, c))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }

        private static bool IsMatchingPair(char open, char close)
        {
            return (open == '(' && close == ')') ||
                    (open == '{' && close == '}') ||
                    (open == '[' && close == ']');
        }
    }
}

