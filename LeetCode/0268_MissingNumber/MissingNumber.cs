namespace LeetCode._0268_MissingNumber
{
    public class MissingNumber
    {
        public int Solve(int[] nums)
        {
            int length = nums.Length;
            int sum = (length * (length + 1)) / 2;

            int actualSum = 0;
            for (int i = 0; i < length; i++)
            {
                actualSum += nums[i];
            }

            return sum - actualSum;
        }
    }
}
