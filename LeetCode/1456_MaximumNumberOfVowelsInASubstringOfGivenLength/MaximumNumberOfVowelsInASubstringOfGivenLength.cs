namespace LeetCode._1456_MaximumNumberOfVowelsInASubstringOfGivenLength
{

    public class MaximumNumberOfVowelsInASubstringOfGivenLength
    {
        public int Solve(string s, int k)
        {
            int start = 0;
            int end = 0 + k - 1;
            int counter = 0;

            for (int i = 0; i <= end; i++)
            {
                char current = s[i];

                if (current == 'a' || current == 'e' || current == 'i' || current == 'o' || current == 'u')
                    counter++;
            }

            int maxNumber = counter;

            while (end < s.Length - 1)
            {
                char oldest = s[start];
                char newest = s[end + 1];

                if (oldest == 'a' || oldest == 'e' || oldest == 'i' || oldest == 'o' || oldest == 'u')
                    counter--;
                if (newest == 'a' || newest == 'e' || newest == 'i' || newest == 'o' || newest == 'u')
                    counter++;

                end++;
                start++;

                if (counter > maxNumber)
                    maxNumber = counter;
            }

            return maxNumber;
        }
	}
}