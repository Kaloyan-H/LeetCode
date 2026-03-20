namespace LeetCode._2225_FindPlayersWithZeroOrOneLosses
{
    public class FindPlayersWithZeroOrOneLosses
    {
        public IList<IList<int>> FindWinners(int[][] matches)
        {
            Dictionary<int, int> playerLosses = new Dictionary<int, int>();

            HashSet<int> players = new HashSet<int>();

            foreach (var match in matches)
            {
                int winner = match[0];
                int loser = match[1];

                players.Add(winner);

                players.Add(loser);
                playerLosses[loser] = playerLosses.GetValueOrDefault(loser, 0) + 1;
            }

            List<int> zeroLosses = new List<int>();
            List<int> oneLoss = new List<int>();

            foreach (var player in players)
            {
                int losses = playerLosses.GetValueOrDefault(player, 0);

                if (losses == 0)
                {
                    zeroLosses.Add(player);
                }
                else if (losses == 1)
                {
                    oneLoss.Add(player);
                }
            }

            zeroLosses.Sort();
            oneLoss.Sort();

            return new List<IList<int>> { zeroLosses, oneLoss };
        }
    }
}
