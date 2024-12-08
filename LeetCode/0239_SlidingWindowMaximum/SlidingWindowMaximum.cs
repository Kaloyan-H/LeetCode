namespace LeetCode._0239_SlidingWindowMaximum
{
    public class SlidingWindowMaximum
    {
        public static int[] Solve(int[] nums, int k)
        {
            if (k == 1)
            {
                return nums;
            }

            int counter = k;
            int maximumTemp = int.MinValue;

            for (int right = 0; right < k - 1; right++)
            {
                if (nums[right] > maximumTemp)
                {
                    maximumTemp = nums[right];
                    counter = k;
                }

                counter--;
            }

            int[] result = new int[nums.Length - k + 1];

            for (int right = k - 1; right < nums.Length; right++)
            {
                if (nums[right] > maximumTemp)
                {
                    maximumTemp = nums[right];
                    result[right - k + 1] = nums[right];
                    counter = k - 1;
                }
                else if (counter == 0)
                {
                    maximumTemp = int.MinValue;

                    for (int innerRight = right - k + 1; innerRight <= right; innerRight++)
                    {
                        if (nums[innerRight] > maximumTemp)
                        {
                            maximumTemp = nums[innerRight];
                            counter = k;
                        }

                        counter--;
                    }

                    result[right - k + 1] = maximumTemp;
                }
                else
                {
                    result[right - k + 1] = maximumTemp;

                    counter--;
                }
            }

            return result;
        }
    }
}
