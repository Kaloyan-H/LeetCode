namespace LeetCode._1004_MaxConsecutiveOnes3
{
    public class MaxConsecutiveOnes3
    {
        public int Solve(int[] nums, int k)
        {
            int left = 0;
            int right = 0;
            int currentZeroCount = 0;

            while (right < nums.Length)
            {
                if (nums[right] == 0)
                {
                    currentZeroCount++;
                }

                right++;

                if (currentZeroCount > k)
                {
                    if (nums[left] == 0)
                    {
                        currentZeroCount--;
                    }
                    left++;
                }
            }

            return right - left;
        }
    }
}
