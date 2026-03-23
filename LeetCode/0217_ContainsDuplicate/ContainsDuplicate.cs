namespace LeetCode._0217_ContainsDuplicate
{
    public class ContainsDuplicate
    {
        public bool Solve(int[] nums)
        {
            // CLEAN SOLUTION, USES A BIT TOO MUCH MEMORY

            HashSet<int> set = new HashSet<int>();

            foreach (var num in nums)
            {
                if (!set.Add(num))
                {
                    return true;
                }
            }

            return false;

            // CLEANER ONE LINER

            //return new HashSet<int>(nums).Count < nums.Length;
        }
    }
}
