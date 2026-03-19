namespace LeetCode._2351_FirstLetterToAppearTwice
{
    public class FirstLetterToAppearTwice
    {
        public char Solve(string s)
        {
            HashSet<char> set = new HashSet<char>();

            int length = s.Length;

            for (int i = 0; i < length; i++)
            {
                char current = s[i];

                if (set.Contains(current))
                {
                    return current;
                }

                set.Add(current);
            }

            return '0';
        }
    }
}
