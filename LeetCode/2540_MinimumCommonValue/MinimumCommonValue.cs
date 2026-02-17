namespace LeetCode._2540_MinimumCommonValue
{
    public class MinimumCommonValue
    {
        public int Solve(int[] nums1, int[] nums2)
        {
            int nums1Counter = 0;
            int nums2Counter = 0;
            
            int mcv = -1;

            while (nums1Counter < nums1.Length && nums2Counter < nums2.Length)
            {
                if (nums1[nums1Counter] == nums2[nums2Counter])
                {
                    mcv = nums1[nums1Counter];
                    break;
                }
                
                if (nums1[nums1Counter] < nums2[nums2Counter])
                {
                    nums1Counter++;
                    continue;
                }

                nums2Counter++;
            }

            return mcv;
        }
    }
}
