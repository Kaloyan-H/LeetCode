using System.Text;

namespace LeetCode._2352_EqualRowAndColumnPairs
{
    public class EqualRowAndColumnPairs
    {
        public int Solve(int[][] grid)
        {
            // SLOWER BUT CLEANER DOUBLE HASHMAP SOLUTION

            //Dictionary<string, int> rowCount = new Dictionary<string, int>();
            //Dictionary<string, int> colCount = new Dictionary<string, int>();

            //int gridLength = grid.Length;

            //for (int i = 0; i < gridLength; i++)
            //{
            //    StringBuilder rowSB = new StringBuilder(200);
            //    StringBuilder colSB = new StringBuilder(200);

            //    for (int j = 0; j < gridLength; j++)
            //    {
            //        rowSB.Append($"{grid[i][j]},");
            //        colSB.Append($"{grid[j][i]},");
            //    }

            //    string row = rowSB.ToString();
            //    string col = colSB.ToString();

            //    rowCount[row] = rowCount.GetValueOrDefault(row, 0) + 1;
            //    colCount[col] = colCount.GetValueOrDefault(col, 0) + 1;
            //}

            //int pairs = 0;

            //foreach (var kvp in rowCount)
            //{
            //    pairs += kvp.Value * colCount.GetValueOrDefault(kvp.Key, 0);
            //}

            //return pairs;

            // A BIT FASTER

            Dictionary<string, int> rowCount = new Dictionary<string, int>();

            int gridLength = grid.Length;

            for (int i = 0; i < gridLength; i++)
            {
                string rowKey = string.Join(",", grid[i]);

                rowCount[rowKey] = rowCount.GetValueOrDefault(rowKey, 0) + 1;
            }

            int pairs = 0;

            for (int i = 0; i < gridLength; i++)
            {
                List<int> colList = new List<int>();

                for (int j = 0; j < gridLength; j++)
                {
                    colList.Add(grid[j][i]);
                }

                string colKey = string.Join(",", colList);

                pairs += rowCount.GetValueOrDefault(colKey, 0);
            }

            return pairs;
        }
    }
}
