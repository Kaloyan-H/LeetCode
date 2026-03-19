namespace LeetCode._1941_CheckIfAllCharactersHaveEqualNumberOfOccurances
{
    public class CheckIfAllCharactersHaveEqualNumberOfOccurances
    {
        public bool Solve(string s)
        {
            // First solution
            HashSet<char> set = new HashSet<char>();
            int length = s.Length;
            int sum = 0;

            foreach (var ch in s)
            {
                set.Add(ch);
                sum += (int)ch;
            }

            int setSum = 0;

            foreach (var ch in set)
            {
                setSum += (int)ch;
            }

            if (length % set.Count != 0 || sum % setSum != 0)
            {
                return false;
            }

            return true;

            // -------------------------------------------------------------------------
            // Optimal solution without hashing for this problem's specific constraints
            // NOTE: Having only lowercase english letters as input makes this possible,
            //       it becomes less viable if the constraints were looser

            //int[] occurrences = new int[26];
            //foreach (char c in s)
            //{
            //    occurrences[c - 'a']++;
            //}

            //int target = 0;
            //foreach (int i in occurrences)
            //{
            //    if (target == 0)
            //    {
            //        if (i != 0) target = i;
            //    }
            //    else if (i != 0 && i != target) return false;
            //}
            //return true;

            // -------------------------------------------------------------------------
            // Another smart solutions with a hashmap and a hashset
            //Dictionary<char, int> hashmap = new Dictionary<char, int>();

            //foreach (var ch in s)
            //{
            //    if (hashmap.ContainsKey(ch))
            //    {
            //        hashmap[ch]++;
            //        continue;
            //    }

            //    hashmap.Add(ch, 0);
            //}

            //HashSet<int> hashset = new HashSet<int>(hashmap.Values);

            //return hashset.Count == 1;
        }
    }
}
