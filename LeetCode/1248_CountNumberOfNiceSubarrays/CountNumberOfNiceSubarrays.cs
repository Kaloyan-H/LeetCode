namespace LeetCode._1248_CountNumberOfNiceSubarrays
{
    public class CountNumberOfNiceSubarrays
    {
        public int Solve(int[] nums, int k)
        {
            // HASHMAP APPROACH

            //Dictionary<int, int> counts = new Dictionary<int, int>();
            //counts[0] = 1;

            //int current = 0;
            //int answer = 0;

            //int length = nums.Length;

            //for (int i = 0; i < length; i++)
            //{
            //    current += nums[i] % 2; // only increments if it's odd

            //    //if (counts.ContainsKey(current - k))
            //    //{
            //    //    answer += counts[current - k];
            //    //}

            //    answer += counts.GetValueOrDefault(current - k, 0); // a more concise version of the above if check

            //    //if (counts.ContainsKey(current))
            //    //{
            //    //    counts[current]++;
            //    //}
            //    //else
            //    //{
            //    //    counts[current] = 1;
            //    //}

            //    counts[current] = counts.GetValueOrDefault(current, 0) + 1;
            //}

            //return answer;

            // SLIDING WINDOW APPROACH

            int answer = 0;

            int currentOddCount = 0;
            int start = 0;

            int length = nums.Length;

            for (int end = 0; end < length; end++)
            {
                if (nums[end] % 2 != 0)
                {
                    currentOddCount++;
                }

                if (currentOddCount == k)
                {
                    answer++;

                    int innerCount = start;

                    while (nums[innerCount] % 2 == 0)
                    {
                        innerCount++;
                        answer++;
                    }
                }

                if (end + 1 < length && nums[end + 1] % 2 != 0 && currentOddCount == k)
                {
                    while (nums[start] % 2 == 0)
                    {
                        start++;
                    }

                    start++;
                    currentOddCount--;
                }
            }

            return answer;
        }
    }
}
