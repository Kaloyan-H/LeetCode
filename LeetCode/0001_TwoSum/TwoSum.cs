namespace LeetCode._0001_TwoSum
{
    public class TwoSum
    {
        public static int[] Solve(int[] nums, int target)
        {
            Dictionary<int, int> numToIndex = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];

                if (numToIndex.ContainsKey(target - num))
                    return [i, numToIndex[target - num]];

                if (numToIndex.ContainsKey(num))
                    numToIndex.Add(num, i);
            }

            return [0, 0];
        }
    }
}
