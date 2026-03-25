namespace LeetCode._0930_BinarySubarraysWithSum
{
    public class BinarySubarraysWithSum
    {
        public int Solve(int[] nums, int goal)
        {
            // FASTER PREFIX SUM APPROACH

            int length = nums.Length;

            int[] prefixSum = new int[length + 1];
            prefixSum[0] = 0;

            int runningSum = 0;

            for (int i = 0; i < length; i++)
            {
                runningSum += nums[i];
                prefixSum[i + 1] = runningSum;
            }

            Dictionary<int, int> sumFrequency = new Dictionary<int, int>();
            sumFrequency[0] = 1;

            int answer = 0;

            for (int i = 1; i <= length; i++)
            {
                int currentPrefixSum = prefixSum[i];

                answer += sumFrequency.GetValueOrDefault(currentPrefixSum - goal, 0);

                sumFrequency[currentPrefixSum] = sumFrequency.GetValueOrDefault(currentPrefixSum, 0) + 1;
            }

            return answer;

            // SLOWER HASHMAP ONLY APPROACH

            //Dictionary<int, int> sumFrequency = new Dictionary<int, int>();
            //sumFrequency[0] = 1;

            //int length = nums.Length;
            //int sum = 0;
            //int answer = 0;

            //for (int i = 0; i < length; i++)
            //{
            //    sum += nums[i];

            //    answer += sumFrequency.GetValueOrDefault(sum - goal, 0);

            //    sumFrequency[sum] = sumFrequency.GetValueOrDefault(sum, 0) + 1;
            //}

            //return answer;

            // FASTEST SLIDING WINDOW APPROACH

            //int i = 0, j = 0, sum = 0, count = 0, freq = 0;

            //while (i < nums.Length)
            //{
            //    sum += nums[i];
            //    if (nums[i] == 1)
            //    {
            //        freq = 0;
            //    }
            //    if (sum > goal)
            //    {
            //        sum -= nums[j];
            //        j++;
            //    }
            //    while (j <= i && sum == goal)
            //    {
            //        sum -= nums[j];
            //        j++;
            //        freq++;
            //    }
            //    count += freq;
            //    i++;
            //}
            //return count;
        }
    }
}
