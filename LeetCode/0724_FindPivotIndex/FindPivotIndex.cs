namespace LeetCode._0724_FindPivotIndex
{
    public class FindPivotIndex
    {
        public int Solve(int[] nums)
        {
            int length = nums.Length;
            int[] sums = new int[length];

            sums[0] = nums[0];

            for (int i = 1; i < length; i++)
            {
                sums[i] = sums[i - 1] + nums[i];
            }

            if (sums[length - 1] - sums[0] == 0)
            {
                return 0;
            }

            for (int i = 1; i < length - 1; i++)
            {
                if (sums[i - 1] == sums[length - 1] - sums[i])
                {
                    return i;
                }
            }

            if (sums[length - 2] == 0)
            {
                return length - 1;
            }

            return -1;
        }
    }
}
