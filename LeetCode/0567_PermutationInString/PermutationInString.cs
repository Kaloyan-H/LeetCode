namespace LeetCode._0567_PermutationInString
{
    public class PermutationInString
    {
        public bool Solve(string s1, string s2)
        {
            int s1Length = s1.Length;
            int s2Length = s2.Length;

            if (s1Length > s2Length)
            {
                return false;
            }

            int[] bucket = new int[26];

            for (int i = 0; i < s1Length; i++)
            {
                bucket[s1[i] - 'a']++;
                bucket[s2[i] - 'a']--;
            }

            if (IsValid(bucket))
                return true;

            for (int right = s1Length; right < s2Length; right++)
            {
                bucket[s2[right] - 'a']--;
                bucket[s2[right - s1Length] - 'a']++;

                if (IsValid(bucket))
                    return true;
            }

            return false;
        }

        private bool IsValid(int[] bucket)
        {
            for (int i = 0; i < 26; i++)
            {
                if (bucket[i] != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
