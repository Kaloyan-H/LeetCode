namespace LeetCode._0977_SquaresOfASortedArray
{
    public class SquaresOfASortedArray
    {
        public int[] Solve(int[] nums)
        {
            int[] output = new int[nums.Length];
            int i = 0;
            int j = nums.Length - 1;
            int indexCounter = j;

            while (i < j)
            {
                int leftNum = (int)Math.Pow(nums[i], 2);
                int rightNum = (int)Math.Pow(nums[j], 2);

                if (leftNum > rightNum)
                {
                    output[indexCounter] = leftNum;
                    i++;
                }
                else
                {
                    output[indexCounter] = rightNum;
                    j--;
                }

                indexCounter--;
            }

            return output;
        }
    }
}
