namespace LeetCode._1456_PathCrossing
{
    public class PathCrossing
    {
        public bool Solve(string path)
        {
            HashSet<string> visitedCoords = new HashSet<string> { "0,0" };

            int x = 0;
            int y = 0;

            foreach (var move in path)
            {
                switch (move)
                {
                    case 'N':
                        y++;
                        break;
                    case 'S':
                        y--;
                        break;
                    case 'E':
                        x++;
                        break;
                    case 'W':
                        x--;
                        break;
                }

                if (!visitedCoords.Add($"{x},{y}"))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
