namespace LeetCode._1413_MinimumValueToGetPositiveStepByStepSum
{
    public class MinimumValueToGetPositiveStepByStepSum
    {
        public int Solve(int[] nums)
        {
            int prefixSum = 0;
            int minimumPrefixSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                prefixSum += nums[i];

                if (prefixSum < minimumPrefixSum)
                {
                    minimumPrefixSum = prefixSum;
                }
            }

            return -minimumPrefixSum + 1;
        }
    }
}
