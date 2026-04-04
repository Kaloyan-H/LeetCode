namespace LeetCode._0346_MovingAverageFromDataStream
{
    public class MovingAverageFromDataStream
    {
        public class MovingAverage
        {
            private double sum;
            private Queue<int> queue;
            private int size;

            public MovingAverage(int size)
            {
                this.sum = 0;
                this.queue = new Queue<int>();
                this.size = size;
            }

            public double Next(int val)
            {
                queue.Enqueue(val);
                sum += val;

                if (queue.Count > size)
                {
                    sum -= queue.Dequeue();
                }

                return sum / queue.Count;
            }
        }
    }
}
