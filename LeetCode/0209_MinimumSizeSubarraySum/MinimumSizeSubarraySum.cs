namespace LeetCode._0209_MinimumSizeSubarraySum
{
    public class MinimumSizeSubarraySum
    {
	    public int Solve(int target, int[] nums)
        {
            int start = 0;
            int end = 0;
            int sum = 0;
            int minLen = int.MaxValue;

            while (end < nums.Length)
            {
                sum += nums[end];

                while (sum >= target)
                {
                    minLen = end - start + 1 < minLen ? end - start + 1 : minLen;
                    sum -= nums[start];
                    start++;
                }

                end++;
            }

            return minLen == int.MaxValue ? 0 : minLen;
        }
	}
}