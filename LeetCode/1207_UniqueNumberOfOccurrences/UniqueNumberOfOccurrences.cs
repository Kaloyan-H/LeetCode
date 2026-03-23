namespace LeetCode._1207_UniqueNumberOfOccurrences
{
    public class UniqueNumberOfOccurrences
    {
        public bool Solve(int[] arr)
        {
            // ------------------------
            // INITIAL HASHMAP APPROACH
            // ------------------------

            //Dictionary<int, int> occurrences = new Dictionary<int, int>();

            //foreach (var num in arr)
            //{
            //    occurrences[num] = occurrences.GetValueOrDefault(num, 0) + 1;
            //}

            //HashSet<int> set = [.. occurrences.Values];

            //return set.Sum() == arr.Length;

            // --------------------------------
            // ANOTHER HASHMAP APPROACH, FASTER
            // --------------------------------

            Dictionary<int, int> occurrences = new Dictionary<int, int>();

            foreach (var num in arr)
            {
                occurrences[num] = occurrences.GetValueOrDefault(num, 0) + 1;
            }

            HashSet<int> set = new HashSet<int>();

            foreach (var kvp in occurrences)
            {
                if (!set.Add(kvp.Value))
                {
                    return false;
                }
            }

            return true;

            // -----------------------------
            // INT ARRAY APPROACH, VERY SLOW
            // -----------------------------

            //int[] occurrences = new int[2001];

            //foreach (var num in arr)
            //{
            //    occurrences[num + 1000]++;
            //}

            //HashSet<int> set = [.. occurrences];

            //return set.Sum() == arr.Length;
        }
    }
}
