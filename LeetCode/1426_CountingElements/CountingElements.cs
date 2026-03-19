namespace LeetCode._1426_CountingElements
{
    public class CountingElements
    {
        public int Solve(int[] arr)
        {
            int counter = 0;
            int length = arr.Length;
            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i < length; i++)
            {
                set.Add(arr[i]);
            }

            for (int i = 0; i < length; i++)
            {
                if (set.Contains(arr[i] + 1))
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
