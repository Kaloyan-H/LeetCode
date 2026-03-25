namespace LeetCode._0290_WordPattern
{
    public class WordPattern
    {
        public bool Solve(string pattern, string s)
        {
            // INITIAL APPROACH, VERY SLOW BECAUSE OF STRING COMPARISON

            //string[] patternMapping = new string[26];
            //Dictionary<string, int> strMapping = new Dictionary<string, int>();

            //string[] str = s.Split(' ');

            //int length = pattern.Length;

            //if (str.Length != length)
            //{
            //    return false;
            //}

            //for (int i = 0; i < length; i++)
            //{
            //    int patternChar = pattern[i] - 'a';
            //    string strWord = str[i];

            //    string mappingPatternWord = patternMapping[patternChar];
            //    int mappingStrChar = strMapping.GetValueOrDefault(strWord, -1);

            //    if (mappingPatternWord == null && mappingStrChar == -1)
            //    {
            //        patternMapping[patternChar] = strWord;
            //        strMapping[strWord] = patternChar;
            //        continue;
            //    }

            //    if (mappingPatternWord != strWord || mappingStrChar != patternChar)
            //    {
            //        return false;
            //    }
            //}

            //return true;

            // SECOND APPROACH WITH HASHSET FOR ALREADY ENCOUNTERED WORDS, MUCH FASTER

            string[] patternMapping = new string[26];
            HashSet<string> set = new HashSet<string>();

            string[] str = s.Split(' ');

            int length = pattern.Length;

            if (str.Length != length)
            {
                return false;
            }

            for (int i = 0; i < length; i++)
            {
                int patternChar = pattern[i] - 'a';
                string strWord = str[i];

                string mappingPatternWord = patternMapping[patternChar];

                if (!set.Add(strWord) && (mappingPatternWord == null || mappingPatternWord != strWord))
                {
                    return false;
                }

                if (mappingPatternWord != strWord && mappingPatternWord != null)
                {
                    return false;
                }

                patternMapping[patternChar] = strWord;
            }

            return true;
        }
    }
}
