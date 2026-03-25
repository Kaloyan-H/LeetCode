namespace LeetCode._2958_LengthOfLongestSubarrayWithAtMostKFrequency
{
    public class LengthOfLongestSubarrayWithAtMostKFrequency
    {
        public int Solve(int[] nums, int k)
        {
            Dictionary<int, int> frequency = new Dictionary<int, int>();

            int longestSubarrayLength = 0;
            int left = 0;
            int length = nums.Length;

            for (int right = 0; right < length; right++)
            {
                int currentNum = nums[right];

                frequency[currentNum] = frequency.GetValueOrDefault(currentNum, 0) + 1;

                while (frequency[currentNum] > k)
                {
                    frequency[nums[left]]--;
                    left++;
                }

                longestSubarrayLength = Math.Max(longestSubarrayLength, right - left + 1);
            }

            return longestSubarrayLength;
        }
    }
}