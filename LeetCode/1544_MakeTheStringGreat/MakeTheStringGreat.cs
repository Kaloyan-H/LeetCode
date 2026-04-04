namespace LeetCode._1544_MakeTheStringGreat
{
    public class MakeTheStringGreat
    {
        public string Solve(string s)
        {
            // INITIAL APPROACH, SLOWER

            //Stack<char> stack = new Stack<char>();

            //foreach (var ch in s)
            //{
            //    if (stack.TryPeek(out char top) &&
            //        char.IsUpper(top) == char.IsLower(ch) &&
            //        (top.ToString().ToLower() == ch.ToString().ToLower()))
            //    {
            //        stack.Pop();
            //    }
            //    else
            //    {
            //        stack.Push(ch);
            //    }
            //}

            //int length = stack.Count;

            //char[] result = new char[length];

            //for (int i = length - 1; i >= 0; i--)
            //{
            //    result[i] = stack.Pop();
            //}

            //return new string(result);

            // OPTIMIZED SECOND APPROACH

            Stack<char> stack = new Stack<char>();

            foreach (var ch in s)
            {
                if (stack.TryPeek(out char top) && // We drop the upper/lower check since the difference is 32, and there are only 26 letters
                    Math.Abs(top - ch) == 32)
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(ch);
                }
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
