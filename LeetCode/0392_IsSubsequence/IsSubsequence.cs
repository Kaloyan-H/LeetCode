namespace LeetCode._0392_IsSubsequence
{
    public class IsSubsquence
    {
        public bool Solve(string s, string t)
        {
            if (s.Length == 0)
            {
                return true;
            }

            int i = 0;
            int j = 0;

            while (i < s.Length && j < t.Length)
            {
                if (s[i] == t[j])
                {
                    i++;
                }

                j++;
            }

            return i == s.Length;
        }
    }
}
