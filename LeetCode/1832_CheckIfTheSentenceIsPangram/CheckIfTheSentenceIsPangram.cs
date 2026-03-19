namespace LeetCode._1832_CheckIfTheSentenceIsPangram
{
    public class CheckIfTheSentenceIsPangram
    {
        public bool Solve(string sentence)
        {
            HashSet<char> set = new HashSet<char>();

            int length = sentence.Length;

            for (int i = 0; i < length; i++)
            {
                set.Add(sentence[i]);
            }

            return set.Count == 26;

            // Faster version, no hashing

            //bool[] seen = new bool[26];
            //int count = 0;

            //for (int i = 0; i < sentence.Length; i++)
            //{
            //    int index = sentence[i] - 'a';

            //    if (!seen[index])
            //    {
            //        seen[index] = true;
            //        count++;
            //    }

            //    if (count == 26)
            //        return true;
            //}

            //return false;
        }
    }
}
