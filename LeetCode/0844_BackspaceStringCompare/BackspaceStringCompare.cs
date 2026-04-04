namespace LeetCode._0844_BackspaceStringCompare
{
    public class BackspaceStringCompare
    {
        public bool Solve(string s, string t)
        {
            // INITIAL INTENDED STACK SOLUTION

            Stack<char> stackS = new Stack<char>();
            Stack<char> stackT = new Stack<char>();

            foreach (var ch in s)
            {
                if (ch == '#')
                {
                    stackS.TryPop(out char top);
                    continue;
                }

                stackS.Push(ch);
            }

            foreach (var ch in t)
            {
                if (ch == '#')
                {
                    stackT.TryPop(out char top);
                    continue;
                }

                stackT.Push(ch);
            }

            int length = stackS.Count;

            if (stackT.Count != length)
                return false;

            for (int i = 0; i < length; i++)
            {
                if (stackS.Pop() != stackT.Pop())
                    return false;
            }

            return true;

            // CLEVER TWO POINTER APPROACH

            //int i = s.Length - 1, j = t.Length - 1;
            //int skipS = 0, skipT = 0;

            //while (i >= 0 || j >= 0)
            //{
            //    while (i >= 0 && (s[i] == '#' || skipS > 0))
            //    {
            //        skipS += s[i] == '#' ? 1 : -1;
            //        i--;
            //    }
 
            //    while (j >= 0 && (t[j] == '#' || skipT > 0))
            //    {
            //        skipT += t[j] == '#' ? 1 : -1;
            //        j--;
            //    }

            //    if (i >= 0 && j >= 0 && s[i] != t[j])
            //        return false;

            //    if ((i >= 0) != (j >= 0))
            //        return false;

            //    i--; j--;
            //}

            //return true;
        }
    }
}
