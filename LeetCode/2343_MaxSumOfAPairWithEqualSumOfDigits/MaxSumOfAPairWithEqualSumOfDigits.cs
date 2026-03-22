namespace LeetCode._2343_MaxSumOfAPairWithEqualSumOfDigits
{
    public class MaxSumOfAPairWithEqualSumOfDigits
    {
        public int Solve(int[] nums)
        {
            // INITIAL SOLUTION, CONVENTIONAL HASHMAP

            Dictionary<int, int> digitSumToLargestNum = new Dictionary<int, int>();

            int largestSum = -1;

            foreach (var num in nums)
            {
                int tempNum = num;
                int digitSum = 0;

                while (tempNum > 0)
                {
                    digitSum += tempNum % 10;
                    tempNum /= 10;
                }

                if (!digitSumToLargestNum.ContainsKey(digitSum))
                {
                    digitSumToLargestNum[digitSum] = num;
                }
                else
                {
                    int largestNumWithDigitSum = digitSumToLargestNum[digitSum];

                    largestSum = Math.Max(largestSum, num + largestNumWithDigitSum);
                    digitSumToLargestNum[digitSum] = Math.Max(largestNumWithDigitSum, num);
                }
            }

            return largestSum;

            // FASTER SOLUTION WITH INT ARRAY INSTEAD OF HASHMAP

            //int[] digitSumToLargestNum = new int[82];
            //Array.Fill(digitSumToLargestNum, -1);

            //int largestSum = -1;

            //foreach (var num in nums)
            //{
            //    int tempNum = num;
            //    int digitSum = 0;

            //    while (tempNum > 0)
            //    {
            //        digitSum += tempNum % 10;
            //        tempNum /= 10;
            //    }

            //    if (digitSumToLargestNum[digitSum] == -1)
            //    {
            //        digitSumToLargestNum[digitSum] = num;
            //    }
            //    else
            //    {
            //        int largestNumWithDigitSum = digitSumToLargestNum[digitSum];

            //        largestSum = Math.Max(largestSum, num + largestNumWithDigitSum);
            //        digitSumToLargestNum[digitSum] = Math.Max(largestNumWithDigitSum, num);
            //    }
            //}

            //return largestSum;
        }
    }
}
