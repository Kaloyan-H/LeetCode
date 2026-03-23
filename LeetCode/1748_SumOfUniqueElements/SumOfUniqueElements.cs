namespace LeetCode._1748_SumOfUniqueElements
{
    public class SumOfUniqueElements
    {
        public int Solve(int[] nums)
        {
            // EFFICIENT INT[] SOLUTION

            int[] occurances = new int[101];

            foreach (var num in nums)
            {
                occurances[num]++;
            }

            int sum = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (occurances[i] == 1)
                    sum += i;
            }

            return sum;

            // CONVENTIONAL HASHMAP SOLUTION, CAN BE FASTER IF WE USE A FOR LOOP INSTEAD OF LINQ

            //Dictionary<int, int> occurances = new Dictionary<int, int>();

            //foreach (var num in nums)
            //{
            //    occurances[num] = occurances.GetValueOrDefault(num, 0) + 1;
            //}

            //return occurances.Where(kvp => kvp.Value == 1).Sum(kvp => kvp.Key);
        }
    }
}
