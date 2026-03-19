namespace LeetCode._2248_IntersectionOfMultipleArrays
{
    public class IntersectionOfMultipleArrays
    {
        public IList<int> Solve(int[][] nums)
        {
            Dictionary<int, int> hashmap = new Dictionary<int, int>();

            int numsLength = nums.Length;

            foreach (int[] arr in nums)
            {
                foreach (int num in arr)
                {
                    if (hashmap.ContainsKey(num))
                    {
                        hashmap[num]++;
                    }
                    else
                    {
                        hashmap[num] = 1;
                    }
                }
            }

            List<int> answer = new List<int>();

            foreach (var key in hashmap.Keys)
            {
                if (hashmap[key] == numsLength)
                {
                    answer.Add(key);
                }
            }

            answer.Sort();

            return answer;

            // Optimized solution specifically for this problem's constraints

            //int[] occurance = new int[1001];
            //foreach (var array in nums)
            //{
            //    foreach (var num in array)
            //    {
            //        occurance[num]++;
            //    }
            //}
            //List<int> res = new();
            //for (int i = 0; i < occurance.Length; i++)
            //{
            //    if (occurance[i] == nums.Length) res.Add(i);
            //}
            //return res;
        }
    }
}
