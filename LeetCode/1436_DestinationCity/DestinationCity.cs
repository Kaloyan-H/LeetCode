namespace LeetCode._1436_DestinationCity
{
    public class DestinationCity
    {
        public string Solve(IList<IList<string>> paths)
        {
            // INITIAL APPROACH

            HashSet<string> isStart = new HashSet<string>();
            HashSet<string> isEnd = new HashSet<string>();

            foreach (var path in paths)
            {
                isStart.Add(path[0]);
                isEnd.Add(path[1]);
            }

            foreach (var ending in isEnd)
            {
                if (!isStart.Contains(ending))
                {
                    return ending;
                }
            }

            return "";

            // A BIT CLEANER

            //HashSet<string> set = new HashSet<string>();

            //foreach (var path in paths)
            //{
            //    set.Add(path[1]);
            //}

            //foreach (var path in paths)
            //{
            //    if (set.Contains(path[0]))
            //    {
            //        set.Remove(path[0]);
            //    }
            //}

            //return set.FirstOrDefault()!;
        }
    }
}
