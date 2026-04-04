namespace LeetCode._0739_DailyTemperatures
{
    public class DailyTemperatures
    {
        public int[] Solve(int[] temperatures)
        {
            int length = temperatures.Length;

            int[] answer = new int[length];

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < length; i++)
            {
                int currentTemp = temperatures[i];

                while (stack.Count > 0 && currentTemp > temperatures[stack.Peek()])
                {
                    int index = stack.Pop();
                    answer[index] = i - index; 
                }

                stack.Push(i);
            }

            return answer;
        }
    }
}
