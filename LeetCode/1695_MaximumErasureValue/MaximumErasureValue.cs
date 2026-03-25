namespace LeetCode._1695_MaximumErasureValue
{
    public class MaximumErasureValue
    {
        public int Solve(int[] nums)
        {
            int maxSum = 0;
            int currentSum = 0;
            int left = 0;
            HashSet<int> set = new HashSet<int>();
            int length = nums.Length;

            for (int right = 0; right < length; right++)
            {
                int currentNum = nums[right];

                currentSum += currentNum;

                if (!set.Add(currentNum))
                {
                    while (nums[left] != currentNum)
                    {
                        currentSum -= nums[left];
                        set.Remove(nums[left]);
                        left++;
                    }

                    currentSum -= currentNum;
                    left++;
                }

                maxSum = Math.Max(maxSum, currentSum);
            }

            return maxSum;
        }
    }
}
