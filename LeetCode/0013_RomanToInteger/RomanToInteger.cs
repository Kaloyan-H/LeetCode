namespace LeetCode._0013_RomanToInteger
{
    public class RomanToInteger
    {
        public static int RomanToInt(string s)
        {
            Dictionary<char, int> charToValue = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            int sum = charToValue[s[0]];

            for (int i = 1; i < s.Length; i++)
            {
                int current = charToValue[s[i]];
                int previous = charToValue[s[i - 1]];

                if (previous < current)
                    sum += current - 2 * previous;
                else
                    sum += current;
            }

            return sum;
        }
    }
}
