using System.Collections.Generic;
using System.Linq;

namespace ComputerScience.Algorithms
{
    public class BalancedExpressions
    {
        private static readonly Dictionary<char, char> matches = new Dictionary<char, char>
        {
            { '>', '<' },
            { ')', '(' },
            { ']', '[' }
        };
        
        public static bool IsBalanced(string input)
        {
            var stack = new Stack<char>();
            var charArray = input.ToCharArray();

            for (var i = 0; i < charArray.Length; i++)
            {
                var character = charArray[i];
                
                if (IsClosingBracket(character))
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    
                    var isMatch = matches[character] == stack.Peek();

                    if (isMatch)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    stack.Push(character);
                }
            }

            return !stack.Any();
        }

        private static bool IsClosingBracket (char bracket) => ")]>".Contains(bracket);
    }
}