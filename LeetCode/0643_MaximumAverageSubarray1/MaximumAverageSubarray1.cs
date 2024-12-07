namespace LeetCode._0643_MaximumAverageSubarray1
{
    public class MaximumAverageSubarray1
    {
        public double Solve(int[] nums, int k)
        {
            /* First approach, both are similar speed */

            //int left = 0;
            //int currentSum = 0;
            //int largestSum = int.MinValue;

            //for (int right = 0; right < nums.Length; right++)
            //{
            //    currentSum += nums[right];

            //    if (right == left + k - 1)
            //    {
            //        if (currentSum > largestSum)
            //        {
            //            largestSum = currentSum;
            //        }
            //        currentSum -= nums[left];
            //        left++;
            //    }
            //}

            //return (double)largestSum / k;

            int currentSum = 0;

            for (int right = 0; right < k; right++)
            {
                currentSum += nums[right];
            }

            int largestSum = currentSum;


            for (int right = k; right < nums.Length; right++)
            {
                currentSum += nums[right] - nums[right - k];

                if (currentSum > largestSum)
                {
                    largestSum = currentSum;
                }
            }

            return (double)largestSum / k;
        }
    }
}
