namespace LeetCode._0933_NumberOfRecentCalls
{
    public class NumberOfRecentCalls
    {
        public class RecentCounter
        {
            public Queue<int> queue;

            public RecentCounter()
            {
                queue = new Queue<int>();
            }

            public int Ping(int t)
            {
                queue.Enqueue(t);

                while (queue.Peek() < t - 3000)
                {
                    queue.Dequeue();
                }

                return queue.Count;
            }
        }
    }
}
