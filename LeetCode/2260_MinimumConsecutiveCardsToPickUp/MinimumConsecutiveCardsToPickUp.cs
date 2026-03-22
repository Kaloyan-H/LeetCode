namespace LeetCode._2260_MinimumConsecutiveCardsToPickUp
{
    public class MinimumConsecutiveCardsToPickUp
    {
        public int Solve(int[] cards)
        {
            Dictionary<int, int> lastCardAppearance = new Dictionary<int, int>();

            int answer = int.MaxValue;
            int length = cards.Length;

            for (int i = 0; i < length; i++)
            {
                int currentCard = cards[i];

                if (lastCardAppearance.ContainsKey(currentCard))
                {
                    answer = Math.Min(i - lastCardAppearance[currentCard] + 1, answer);
                }

                lastCardAppearance[currentCard] = i;
            }

            return answer == int.MaxValue ? -1 : answer;
        }
    }
}
