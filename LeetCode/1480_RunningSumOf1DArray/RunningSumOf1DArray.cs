namespace LeetCode._1480_RunningSumOf1DArray
{
    public class RunningSumOf1DArray
    {
        public int[] Solve(int[] nums)
        {
            int numsLength = nums.Length;

            int[] result = new int[numsLength];

            result[0] = nums[0];

            for (int i = 0; i < numsLength; i++)
            {
                result[i] = result[i - 1] + nums[i];
            }

            return result;
        }
    }
}
