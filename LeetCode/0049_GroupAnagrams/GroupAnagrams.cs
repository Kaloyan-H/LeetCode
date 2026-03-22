namespace LeetCode._0049_GroupAnagrams
{
    public class GroupAnagrams
    {
        public IList<IList<string>> Solve(string[] strs)
        {
            Dictionary<string, IList<string>> wordGroups = new Dictionary<string, IList<string>>();

            foreach (var str in strs)
            {
                char[] count = new char[26];

                foreach (var c in str)
                {
                    count[c - 'a']++;
                }

                string key = new string(count);

                if (!wordGroups.ContainsKey(key))
                {
                    wordGroups[key] = new List<string>();
                }

                wordGroups[key].Add(str);
            }

            return wordGroups.Values.ToList();
        }
    }
}
