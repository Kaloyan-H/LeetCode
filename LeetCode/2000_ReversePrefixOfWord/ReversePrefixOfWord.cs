namespace LeetCode._2000_ReversePrefixOfWord
{
    public class ReversePrefixOfWord
    {
        public string Solve(string word, char ch)
        {
            char[] chars = word.ToCharArray();

            int left = 0;
            int right = 0;

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == ch)
                {
                    right = i;
                    break;
                }
            }

            while (left < right)
            {
                char temp = chars[left];
                chars[left] = chars[right];
                chars[right] = temp;
                left++;
                right--;
            }

            return new string(chars);
        }
    }
}