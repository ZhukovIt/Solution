using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solution.Structures;

namespace Solution
{
    public sealed class ValidParenthesesSolution
    {
        public bool IsValidParentheses(string parentheses)
        { 
            Stack<char> _CharStack = new Stack<char>();

            foreach (char c in parentheses)
            {
                _CharStack.Push(c);

                if (_CharStack.Count >= 2)
                {
                    char _Second = _CharStack.Pop();
                    char _First = _CharStack.Pop();

                    if (!IsCorrectParentheses(_First, _Second))
                    {
                        _CharStack.Push(_First);
                        _CharStack.Push(_Second);
                    }
                }
            }

            return _CharStack.Count == 0;
        }

        private bool IsCorrectParentheses(char _First, char _Second)
        {
            if (_First == '(' && _Second == ')')
            {
                return true;
            }
            else if (_First == '{' && _Second == '}')
            {
                return true;
            }
            else if (_First == '[' && _Second == ']')
            {
                return true;
            }

            return false;
        }
    }
}
