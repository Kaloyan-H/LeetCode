namespace LeetCode._0771_JewelsAndStones
{
    public class JewelsAndStones
    {
        public int Solve(string jewels, string stones)
        {
            // FASTER INT ARRAY APPROACH

            int[] stonesCount = new int[58];

            foreach (var stone in stones)
            {
                stonesCount[stone - 'A']++;
            }

            int jewelsCount = 0;

            foreach (var jewel in jewels)
            {
                jewelsCount += stonesCount[jewel - 'A'];
            }

            return jewelsCount;

            // SLOWER CONVENTIONAL HASHMAP APPROACH

            //Dictionary<char, int> stoneCount = new Dictionary<char, int>();

            //foreach (var stone in stones)
            //{
            //    stoneCount[stone] = stoneCount.GetValueOrDefault(stone, 0) + 1;
            //}

            //int jewelsCount = 0;

            //foreach (var jewel in jewels)
            //{
            //    jewelsCount += stoneCount.GetValueOrDefault(jewel, 0);
            //}

            //return jewelsCount;
        }
    }
}
