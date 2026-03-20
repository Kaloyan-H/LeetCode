namespace LeetCode._0560_SubarraySumEqualsK
{
    public class SubarraySumEqualsK
    {
        public int Solve(int[] nums, int k)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();
            counts[0] = 1;

            int length = nums.Length;
            int current = 0;
            int answer = 0;

            for (int i = 0; i < length; i++)
            {
                current += nums[i];

                if (counts.ContainsKey(current - k))
                {
                    answer += counts[current - k];
                }

                if (counts.ContainsKey(current))
                {
                    counts[current]++;
                }
                else
                {
                    counts[current] = 1;
                }

            }

            return answer;
        }
    }
}
