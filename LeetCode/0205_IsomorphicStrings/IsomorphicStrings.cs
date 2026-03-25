namespace LeetCode._0205_IsomorphicStrings
{
    public class IsomorphicStrings
    {
        public bool Solve(string s, string t)
        {
            int[] sMapping = new int[128];
            int[] tMapping = new int[128];
            // We don't have to fill the arrays with -1 since 0 will not be encountered as a valid ascii symbol

            int length = s.Length;

            for (int i = 0; i < length; i++)
            {
                char sChar = s[i];
                char tChar = t[i];

                int mappingSChar = sMapping[sChar];
                int mappingTChar = tMapping[tChar];

                if (mappingSChar == 0 && mappingTChar == 0)
                {
                    sMapping[sChar] = tChar;
                    tMapping[tChar] = sChar;
                    continue;
                }

                if (mappingSChar != tChar || mappingTChar != sChar)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
