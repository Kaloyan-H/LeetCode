namespace LeetCode._0917_ReverseOnlyLetters
{
    public class ReverseOnlyLetters
    {
        public string Solve(string s)
        {
            int left = 0;
            int right = s.Length - 1;

            char[] chars = s.ToCharArray();

            while (left < right)
            {
                if (char.IsLetter(chars[left]) && char.IsLetter(chars[right]))
                {
                    char temp = chars[left];
                    chars[left] = chars[right];
                    chars[right] = temp;

                    left++;
                    right--;
                    continue;
                }

                if (!char.IsLetter(chars[left]))
                {
                    left++;
                }
                if (!char.IsLetter(chars[right]))
                {
                    right--;
                }
            }

            return new string(chars);
        }
    }
}