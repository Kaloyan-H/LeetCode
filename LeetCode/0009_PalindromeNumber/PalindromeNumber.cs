namespace LeetCode._0009_PalindromeNumber
{
    public class PalindromeNumber
    {
        public static bool Solve(int x)
        {
            string number = x.ToString();

            int i = 0;
            int j = number.Length - 1;

            while (i < j)
            {
                if (number[i] != number[j])
                    return false;

                i++;
                j--;
            }

            return true;
        }
    }
}
