namespace LeetCode._0020_ValidParentheses
{
    public class ValidParentheses
    {
        public bool Solve(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (var ch in s)
            {
                switch (ch)
                {
                    case ')':
                        if (stack.Count == 0 || stack.Pop() != '(')
                            return false;
                        break;
                    case '}':
                        if (stack.Count == 0 || stack.Pop() != '{')
                            return false;
                        break;
                    case ']':
                        if (stack.Count == 0 || stack.Pop() != '[')
                            return false;
                        break;
                    case '(':
                    case '{':
                    case '[':
                        stack.Push(ch);
                        break;
                    default:
                        break;
                }
            }

            return stack.Count == 0;
        }
    }
}
