namespace LeetCode._2270_NumberOfWaysToSplitAnArray
{
    public class NumberOfWaysToSplitAnArray
    {
        public int Solve(int[] nums)
        {
            if (nums.Length < 2)
                return 0;

            /* First intuitive approach */

            //int numsLength = nums.Length;

            //long[] prefix = new long[numsLength];

            //prefix[0] = nums[0];

            //for (int i = 1; i < numsLength; i++)
            //{
            //    prefix[i] = prefix[i - 1] + nums[i];
            //}

            //int result = 0;

            //for (int i = 0; i < numsLength - 1; i++)
            //{
            //    long leftSection = prefix[i];

            //    if (leftSection >= prefix[numsLength - 1] - leftSection)
            //    {
            //        result++;
            //    }
            //}

            //return result;

            /* Faster appraoch without prefix array */

            long sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum = sum + nums[i];
            }

            int result = 0;
            long leftSection = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                leftSection += nums[i];
                long rightSection = sum - leftSection;

                if (leftSection >= rightSection)
                    result++;
            }

            return result;
        }
    }
}
