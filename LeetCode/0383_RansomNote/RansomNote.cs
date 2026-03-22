namespace LeetCode._0383_RansomNote
{
    public class RansomNote
    {
        public bool Solve(string ransomNote, string magazine)
        {
            // SLOWER HASHMAP APPROACH

            //Dictionary<char, int> magazineLetterCount = new Dictionary<char, int>();

            //foreach (var letter in magazine)
            //{
            //    magazineLetterCount[letter] = magazineLetterCount.GetValueOrDefault(letter, 0) + 1;
            //}

            //foreach (var letter in ransomNote)
            //{
            //    if (!magazineLetterCount.ContainsKey(letter) || magazineLetterCount[letter] == 0)
            //    {
            //        return false;
            //    }

            //    magazineLetterCount[letter]--;
            //}

            //return true;

            // FASTER INT ARRAY APPROACH

            int[] magazineLetterCount = new int[26];

            foreach (var letter in magazine)
            {
                magazineLetterCount[letter - 'a']++;
            }

            foreach (var letter in ransomNote)
            {
                int index = letter - 'a';

                if (magazineLetterCount[index] == 0)
                {
                    return false;
                }

                magazineLetterCount[index]--;
            }

            return true;
        }
    }
}
