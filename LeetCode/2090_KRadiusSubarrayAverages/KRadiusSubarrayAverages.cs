namespace LeetCode._2090_KRadiusSubarrayAverages
{
    public class KRadiusSubarrayAverages
    {
        public static int[] Solve(int[] nums, int k)
        {
            //int numsLength = nums.Length;

            //int[] result = new int[numsLength];

            //int subarrayLength = 2 * k + 1;

            //if (numsLength < subarrayLength)
            //{
            //    for (int i = 0; i < numsLength; i++)
            //    {
            //        result[i] = -1;
            //    }

            //    return result;
            //}

            //for (int i = 0; i < k; i++)
            //{
            //    result[i] = -1;
            //    result[numsLength - i - 1] = -1;
            //}

            //int left = 0;
            //int right = 0;
            //long sum = 0;

            //while (right <= k * 2)
            //{
            //    sum += nums[right];
            //    right++;
            //}

            //for (int i = k; i < numsLength - k - 1; i++)
            //{
            //    result[i] = (int)(sum / subarrayLength);
            //    sum += nums[right];
            //    sum -= nums[left];
            //    right++;
            //    left++;
            //}

            //result[numsLength - k - 1] = (int)(sum / subarrayLength);

            //return result;

            if (k == 0)
            {
                return nums;
            }

            int numsLength = nums.Length;
            int subarrayLength = 2 * k + 1;

            int[] result = new int[numsLength];

            if (numsLength < subarrayLength)
            {
                for (int i = 0; i < numsLength; i++)
                {
                    result[i] = -1;
                }

                return result;
            }

            for (int i = 0; i < k; i++)
            {
                result[i] = -1;
                result[numsLength - i - 1] = -1;
            }

            long[] prefixSums = new long[nums.Length];

            prefixSums[0] = nums[0];

            for (int i = 1; i < numsLength; i++)
            {
                prefixSums[i] = prefixSums[i - 1] + nums[i];
            }

            result[k] = (int)(prefixSums[k * 2] / subarrayLength);

            for (int i = k + 1; i < numsLength - k; i++)
            {
                result[i] = (int)((prefixSums[i + k] - prefixSums[i - k - 1]) / subarrayLength);
            }

            return result;
        }
    }
}
