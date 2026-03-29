namespace LeetCode._1047_RemoveAllAdjacentDuplicatesInString
{
    public class RemoveAllAdjacentDuplicatesInString
    {
        public string Solve(string s)
        {
            if (s.Length == 1)
                return s;

            Stack<char> stack = new Stack<char>();

            foreach (var ch in s)
            {
                if (stack.TryPeek(out char top) && ch == top)
                {
                    stack.Pop();
                    continue;
                }

                stack.Push(ch);
            }

            int length = stack.Count;
            char[] result = new char[length];

            for (int i = length - 1; i >= 0; i--)
            {
                result[i] = stack.Pop();
            }

            return new string(result);
        }
    }
}
