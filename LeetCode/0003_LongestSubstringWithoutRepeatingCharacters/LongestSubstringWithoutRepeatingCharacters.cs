namespace LeetCode._0003_LongestSubstringWithoutRepeatingCharacters
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public int Solve(string s)
        {
            // SLOWER HASHSET SOLUTION

            //HashSet<char> encountered = new HashSet<char>();

            //int longestSubstringLength = 0;

            //int left = 0;
            //int length = s.Length;

            //for (int right = 0; right < length; right++)
            //{
            //    char currentChar = s[right];

            //    if (!encountered.Add(currentChar))
            //    {
            //        while (s[left] != currentChar)
            //        {
            //            encountered.Remove(s[left]);
            //            left++;
            //        }

            //        left++;
            //    }

            //    longestSubstringLength = Math.Max(longestSubstringLength, encountered.Count);
            //}

            //return longestSubstringLength;

            // FASTER BOOL ARRAY SOLUTION

            bool[] encountered = new bool[128];

            int longestSubstringLength = 0;

            int left = 0;
            int length = s.Length;

            for (int right = 0; right < length; right++)
            {
                char currentChar = s[right];

                if (encountered[currentChar])
                {
                    while (s[left] != currentChar)
                    {
                        encountered[s[left]] = false;
                        left++;
                    }

                    left++;
                }

                encountered[currentChar] = true;

                longestSubstringLength = Math.Max(longestSubstringLength, right - left + 1);
            }

            return longestSubstringLength;
        }
    }
}
