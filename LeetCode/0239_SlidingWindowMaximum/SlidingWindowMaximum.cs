namespace LeetCode._0239_SlidingWindowMaximum
{
    public class SlidingWindowMaximum
    {
        public static int[] Solve(int[] nums, int k)
        {
            // ------------------------
            // OPTIMIZED DEQUE APPROACH
            // ------------------------

            LinkedList<int> deque = new LinkedList<int>();

            for (int i = 0; i < k; i++)
            {
                int current = nums[i];

                while (deque.Count > 0 && nums[deque.Last!.Value] < current)
                {
                    deque.RemoveLast();
                }

                deque.AddLast(i);
            }

            int length = nums.Length;
            int[] answer = new int[length - k + 1];

            int right = k - 1;

            for (int left = 0; left < length - k + 1; left++)
            {
                int currentLargestIndex = deque.First!.Value;

                answer[left] = nums[currentLargestIndex];

                if (currentLargestIndex == left)
                {
                    deque.RemoveFirst();
                }

                right++;

                if (right < length)
                {
                    int newRight = nums[right];

                    while (deque.Count > 0 && nums[deque.Last!.Value] < newRight)
                    {
                        deque.RemoveLast();
                    }

                    deque.AddLast(right);
                }
            }

            return answer;

            // -------------------------------------------------------------------
            // INITIAL SOLUTION FROM A LONG TIME AGO, NO DSA KNOWLEDGE AT THE TIME
            // -------------------------------------------------------------------

            //if (k == 1)
            //{
            //    return nums;
            //}

            //int counter = k;
            //int maximumTemp = int.MinValue;

            //for (int right = 0; right < k - 1; right++)
            //{
            //    if (nums[right] > maximumTemp)
            //    {
            //        maximumTemp = nums[right];
            //        counter = k;
            //    }

            //    counter--;
            //}

            //int[] result = new int[nums.Length - k + 1];

            //for (int right = k - 1; right < nums.Length; right++)
            //{
            //    if (nums[right] > maximumTemp)
            //    {
            //        maximumTemp = nums[right];
            //        result[right - k + 1] = nums[right];
            //        counter = k - 1;
            //    }
            //    else if (counter == 0)
            //    {
            //        maximumTemp = int.MinValue;

            //        for (int innerRight = right - k + 1; innerRight <= right; innerRight++)
            //        {
            //            if (nums[innerRight] > maximumTemp)
            //            {
            //                maximumTemp = nums[innerRight];
            //                counter = k;
            //            }

            //            counter--;
            //        }

            //        result[right - k + 1] = maximumTemp;
            //    }
            //    else
            //    {
            //        result[right - k + 1] = maximumTemp;

            //        counter--;
            //    }
            //}

            //return result;
        }
    }
}
