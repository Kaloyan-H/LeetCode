namespace LeetCode._0303_RangeSumQueryImmutable
{
    public class NumArray
    {
        private int[] prefixSums;

        public NumArray(int[] nums)
        {
            int length = nums.Length;

            prefixSums = new int[length];

            prefixSums[0] = nums[0];

            for (int i = 1; i < length; i++)
            {
                prefixSums[i] = prefixSums[i - 1] + nums[i];
            }
        }

        public int SumRange(int left, int right)
        {
            if (left == 0)
            {
                return prefixSums[right];
            }

            return prefixSums[right] - prefixSums[left - 1];
        }
    }
}
