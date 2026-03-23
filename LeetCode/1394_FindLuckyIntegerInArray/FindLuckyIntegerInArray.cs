namespace LeetCode._1394_FindLuckyIntegerInArray
{
    public class FindLuckyIntegerInArray
    {
        public int Solve(int[] arr)
        {
            // FASTER INT[] APPROACH

            int[] frequency = new int[501];

            foreach (var num in arr)
            {
                frequency[num]++;
            }

            for (int i = 500; i >= 1; i--)
            {
                if (i == frequency[i])
                {
                    return i;
                }
            }

            return -1;

            // CONVENTIONAL HASHMAP APPROACH

            //Dictionary<int, int> frequency = new Dictionary<int, int>();

            //foreach (var num in arr)
            //{
            //    frequency[num] = frequency.GetValueOrDefault(num, 0) + 1;
            //}

            //int answer = -1;

            //foreach (var kvp in frequency)
            //{
            //    int key = kvp.Key;

            //    if (key == kvp.Value)
            //    {
            //        answer = Math.Max(answer, key);
            //    }
            //}

            //return answer;
        }
    }
}
