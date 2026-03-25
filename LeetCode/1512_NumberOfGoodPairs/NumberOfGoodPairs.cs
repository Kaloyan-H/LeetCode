namespace LeetCode._1512_NumberOfGoodPairs
{
    public class NumberOfGoodPairs
    {
        public int Solve(int[] nums)
        {
            int[] frequency = new int[101];

            foreach (var num in nums)
            {
                frequency[num]++;
            }

            int answer = 0;

            for (int i = 1; i <= 100; i++)
            {
                int currentFrequency = frequency[i];

                if (currentFrequency > 1)
                {
                    // Typical combination problem, using (k * (k - 1)) / 2 formula
                    answer += (currentFrequency * (currentFrequency - 1)) / 2;
                }
            }

            return answer;
        }
    }
}
