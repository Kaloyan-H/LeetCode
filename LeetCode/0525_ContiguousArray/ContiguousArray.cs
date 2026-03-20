namespace LeetCode._0525_ContiguousArray
{
    public class ContiguousArray
    {
        public int Solve(int[] nums)
        {
            Dictionary<int, int> firstDiffAppearance = new Dictionary<int, int>();

            firstDiffAppearance[0] = -1;

            int zeros = 0;
            int ones = 0;
            int maxSubarrLength = 0;

            int numsLength = nums.Length;

            for (int i = 0; i < numsLength; i++)
            {
                if (nums[i] == 0)
                {
                    zeros++;
                }
                else
                {
                    ones++;
                }

                int diff = zeros - ones;

                if (firstDiffAppearance.ContainsKey(diff))
                {
                    maxSubarrLength = Math.Max(maxSubarrLength, i - firstDiffAppearance[diff]);
                }
                else
                {
                    firstDiffAppearance.Add(diff, i);
                }
            }

            return maxSubarrLength;
        }
    }
}
