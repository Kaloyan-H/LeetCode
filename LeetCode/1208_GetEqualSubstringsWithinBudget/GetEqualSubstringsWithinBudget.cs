namespace LeetCode._1208_GetEqualSubstringsWithinBudget
{
    public class GetEqualSubstringsWithinBudget
    {
        public int Solve(string s, string t, int maxCost)
        {
            int length = s.Length;
            int start = 0;
            int currentCost = 0;
            int maxLength = 0;

            for (int end = 0; end < length; end++)
            {
                currentCost += Math.Abs(s[end] - t[end]);

                while (currentCost > maxCost)
                {
                    currentCost -= Math.Abs(s[start] - t[start]);
                    start++;
                }

                maxLength = Math.Max(maxLength, end - start + 1);
            }

            return maxLength;
        }
    }
}
