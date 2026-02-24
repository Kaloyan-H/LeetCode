namespace LeetCode._0167_TwoSumII
{
    public class TwoSumII
    {
        public static int[] Solve(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                int sum = nums[left] + nums[right];

                if (sum == target)
                {
                    return new int[] { left + 1, right + 1 };
                }
                else if (sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return [0, 0];
        }
    }
}

