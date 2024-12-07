namespace LeetCode._0334_ReverseString
{
    public class ReverseString
    {
        public static void Solution(char[] s)
        {
            int i = 0;
            int j = s.Length - 1;

            while (i < j)
            {
                char ch1 = s[i];
                char ch2 = s[j];

                s[i] = ch2;
                s[j] = ch1;

                i++;
                j--;
            }

            Console.WriteLine($"[{string.Join(", ", s)}]");
        }
    }
}
