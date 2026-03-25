using System.Text;

namespace LeetCode._0791_CustomSortString
{
    public class CustomSortString
    {
        public string Solve(string order, string s)
        {
            // CONVENTIONAL HASHMAP APPROACH

            //Dictionary<char, int> frequencyMapping = new Dictionary<char, int>();

            //foreach (var ch in s)
            //{
            //    frequencyMapping[ch] = frequencyMapping.GetValueOrDefault(ch, 0) + 1;
            //}

            //StringBuilder sb = new StringBuilder(200);

            //foreach (var ch in order)
            //{
            //    int freq = frequencyMapping.GetValueOrDefault(ch, 0);

            //    for (int i = 0; i < freq; i++)
            //    {
            //        sb.Append(ch);
            //    }

            //    frequencyMapping.Remove(ch);
            //}

            //foreach (var kvp in frequencyMapping)
            //{
            //    int freq = kvp.Value;
            //    char ch = kvp.Key;

            //    for (int i = 0; i < freq; i++)
            //    {
            //        sb.Append(ch);
            //    }
            //}

            //return sb.ToString();

            // FASTER INT ARRAY VERSION

            int[] frequencyMapping = new int[26];

            foreach (var ch in s)
            {
                frequencyMapping[ch - 'a']++;
            }

            StringBuilder sb = new StringBuilder(200);

            foreach (var ch in order)
            {
                int freq = frequencyMapping[ch - 'a'];

                for (int i = 0; i < freq; i++)
                {
                    sb.Append(ch);
                }

                frequencyMapping[ch - 'a'] = 0;
            }

            for (int i = 0; i < 26; i++)
            {
                int freq = frequencyMapping[i];

                for (int j = 0; j < freq; j++)
                {
                    sb.Append((char)(i + 'a'));
                }
            }

            return sb.ToString();
        }
    }
}
