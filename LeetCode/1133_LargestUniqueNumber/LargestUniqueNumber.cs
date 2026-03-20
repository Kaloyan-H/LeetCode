namespace LeetCode._1133_LargestUniqueNumber
{
    public class LargestUniqueNumber
    {
        public int Solve(int[] nums)
        {
            //int[] numsOccurance = new int[1001];

            //foreach (var num in nums)
            //{
            //    numsOccurance[num]++;
            //}

            //for (int i = 1000; i >= 0; i--)
            //{
            //    if (numsOccurance[i] == 1)
            //    {
            //        return i;
            //    }
            //}

            //return -1;

            Dictionary<int, int> numberOccurances = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                numberOccurances[num] = numberOccurances.GetValueOrDefault(num, 0) + 1;
            }

            return numberOccurances
                .Where(kvp => kvp.Value == 1)
                .OrderBy(kvp => kvp.Key)
                .Select(kvp => kvp.Key)
                .LastOrDefault(-1);
        }
    }
}
