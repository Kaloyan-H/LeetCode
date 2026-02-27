namespace LeetCode._1732_FindTheHighestAltitude
{
    public class FindTheHighestAltitude
    {
        public int Solve(int[] gain)
        {
            int highestAltitude = 0;
            int currentAltitude = 0;
            int length = gain.Length;

            for (int i = 0; i < length; i++)
            {
                currentAltitude += gain[i];
                highestAltitude = Math.Max(currentAltitude, highestAltitude);
            }

            return highestAltitude;
        }
    }
}
