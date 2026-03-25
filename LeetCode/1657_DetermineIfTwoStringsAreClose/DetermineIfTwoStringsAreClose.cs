namespace LeetCode._1657_DetermineIfTwoStringsAreClose
{
    public class DetermineIfTwoStringsAreClose
    {
        public bool Solve(string word1, string word2)
        {
            // INITIAL INTUITION APPROACH

            //int length = word1.Length;

            //if (length != word2.Length)
            //    return false;

            //int[] frequency1 = new int[26];
            //int[] frequency2 = new int[26];

            //for (int i = 0; i < length; i++)
            //{
            //    frequency1[word1[i] - 'a']++;
            //    frequency2[word2[i] - 'a']++;
            //}

            //Dictionary<int, int> freqFrequency1 = new Dictionary<int, int>();
            //Dictionary<int, int> freqFrequency2 = new Dictionary<int, int>();

            //for (int i = 0; i < 26; i++)
            //{
            //    int freq1 = frequency1[i];
            //    int freq2 = frequency2[i];

            //    if ((freq1 == 0) != (freq2 == 0))
            //        return false;

            //    freqFrequency1[freq1] = freqFrequency1.GetValueOrDefault(freq1, 0) + 1;
            //    freqFrequency2[freq2] = freqFrequency2.GetValueOrDefault(freq2, 0) + 1;
            //}

            //foreach (var freq1Kvp in freqFrequency1)
            //{
            //    if (freq1Kvp.Value != freqFrequency2.GetValueOrDefault(freq1Kvp.Key))
            //        return false;
            //}

            //return true;

            // FASTER ARRAY SORT APPROACH

            int length = word1.Length;

            if (length != word2.Length)
                return false;

            int[] frequency1 = new int[26];
            int[] frequency2 = new int[26];

            for (int i = 0; i < length; i++)
            {
                frequency1[word1[i] - 'a']++;
                frequency2[word2[i] - 'a']++;
            }

            for (int i = 0; i < 26; i++)
            {
                if ((frequency1[i] == 0) != (frequency2[i] == 0))
                    return false;
            }

            Array.Sort(frequency1);
            Array.Sort(frequency2);

            for (int i = 0; i < 26; i++)
            {
                if (frequency1[i] != frequency2[i])
                    return false;
            }

            return true;
        }
    }
}
