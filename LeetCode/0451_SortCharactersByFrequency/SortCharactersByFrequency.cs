using System.Text;

namespace LeetCode._0451_SortCharactersByFrequency
{
    public class SortCharactersByFrequency
    {
        public string Solve(string s)
        {
            // INITIAL APPROACH, NOT THE FASTEST

            //Dictionary<char, int> frequency = new Dictionary<char, int>();

            //foreach (var ch in s)
            //{
            //    frequency[ch] = frequency.GetValueOrDefault(ch, 0) + 1;
            //}

            //frequency = frequency.OrderByDescending(kvp => kvp.Value).ToDictionary();

            //List<char> answer = new List<char>();

            //foreach (var kvp in frequency)
            //{
            //    char key = kvp.Key;

            //    for (int i = 0; i < kvp.Value; i++)
            //    {
            //        answer.Add(key);
            //    }
            //}

            //return String.Join("", answer);

            // SECOND APPROACH, A BIT FASTER

            Dictionary<char, int> frequency = new Dictionary<char, int>();

            foreach (var ch in s)
            {
                frequency[ch] = frequency.GetValueOrDefault(ch, 0) + 1;
            }

            List<char>[] frequencyBucket = new List<char>[s.Length + 1];

            foreach (var kvp in frequency)
            {
                int freq = kvp.Value;

                if (frequencyBucket[freq] == null)
                {
                    frequencyBucket[freq] = new List<char>();
                }

                frequencyBucket[freq].Add(kvp.Key);
            }

            StringBuilder sb = new StringBuilder(s.Length);

            for (int i = frequencyBucket.Length - 1; i >= 1; i--)
            {
                if (frequencyBucket[i] != null)
                {
                    foreach (var ch in frequencyBucket[i])
                    {
                        for (int j = 0; j < i; j++) // Here a for loop is faster than sb.Append() with a number of times as a parameter
                        {
                            sb.Append(ch);
                        }
                    }
                }
            }

            return sb.ToString();
        }
    }
}
