namespace LeetCode._3005_CountElementsWithMaximumFrequency
{
    public class CountElementsWithMaximumFrequency
    {
        public int Solve(int[] nums)
        {
            int[] frequency = new int[101];
            int maxFrequncy = 0;

            foreach (var num in nums)
            {
                frequency[num]++;
                maxFrequncy = Math.Max(maxFrequncy, frequency[num]);
            }

            int answer = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (frequency[i] == maxFrequncy)
                {
                    answer += maxFrequncy;
                }
            }

            return answer;
        }
    }
}
