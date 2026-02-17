namespace LeetCode._0283_MoveZeroes
{
    public class MoveZeroes
    {
        public void Solve(int[] nums)
        {
            int left = 0;

            for (int right = 0; right < nums.Length; right++)
            {
                if (nums[right] != 0)
                {
                    if (right != left)
                    {
                        int temp = nums[right];
                        nums[right] = nums[left];
                        nums[left] = temp;
                    }
                    
                    left++;
                }
            }
        }
    }
}
