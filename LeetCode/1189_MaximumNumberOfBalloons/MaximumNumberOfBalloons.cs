namespace LeetCode._1189_MaximumNumberOfBalloons
{
    public class MaximumNumberOfBalloons
    {
        public int Solve(string text)
        {
            Dictionary<char, int> lettersCount = new Dictionary<char, int>
            {
                { 'b', 0 },
                { 'a', 0 },
                { 'l', 0 },
                { 'o', 0 },
                { 'n', 0 }
            };

            foreach (var ch in text)
            {
                if (lettersCount.ContainsKey(ch))
                {
                    lettersCount[ch]++;
                }
            }

            lettersCount['l'] = lettersCount['l'] / 2;
            lettersCount['o'] = lettersCount['o'] / 2;

            int answer = int.MaxValue;

            foreach (var value in lettersCount.Values)
            {
                if (value < answer)
                {
                    answer = value;
                }
            }

            return answer;
        }
    }
}
