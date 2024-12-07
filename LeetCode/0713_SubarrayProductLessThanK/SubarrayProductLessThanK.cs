namespace LeetCode._0713_SubarrayProductLessThanK
{
    public class SubarrayProductLessThanK
    {
        public int Solve(int[] nums, int k)
        {
            if (k <= 1)
            {
                return 0;
            }

            int left = 0;
            int currentProduct = 1;
            int result = 0;

            for (int right = 0; right < nums.Length; right++)
            {
                currentProduct *= nums[right];

                while (currentProduct >= k)
                {
                    currentProduct /= nums[left];
                    left++;
                }

                result += right - left + 1;
            }

            return result;
        }
    }
}
