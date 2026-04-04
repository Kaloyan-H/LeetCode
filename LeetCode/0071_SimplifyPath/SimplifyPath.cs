namespace LeetCode._0071_SimplifyPath
{
    public class SimplifyPath
    {
        public string Solve(string path)
        {
            string[] pathArr = path.Split('/', StringSplitOptions.RemoveEmptyEntries);

            Stack<string> stack = new Stack<string>();

            foreach (var element in pathArr)
            {
                if (element == "..")
                {
                    stack.TryPop(out string? temp);
                }
                else if (element != ".")
                {
                    stack.Push(element);
                }
            }

            int length = stack.Count;

            string[] result = new string[length];

            for (int i = length - 1; i >= 0; i--)
            {
                result[i] = stack.Pop();
            }

            return $"/{string.Join('/', result)}";
        }
    }
}
