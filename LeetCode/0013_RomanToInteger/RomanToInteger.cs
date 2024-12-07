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

            int sum = 0;

            int previous = charToValue[s[0]];

            for (int i = 1; i < s.Length; i++)
            {
                int current = charToValue[s[i]];

                if (previous < current)
                {
                    sum -= current;
                }
                else
                {
                    sum += current;
                }

                previous = current;
            }

            return sum;
        }
    }
}
