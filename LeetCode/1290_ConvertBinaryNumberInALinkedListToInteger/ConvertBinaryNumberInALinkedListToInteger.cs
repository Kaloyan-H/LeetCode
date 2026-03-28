namespace LeetCode._1290_ConvertBinaryNumberInALinkedListToInteger
{
    public class ListNode
    {
        public int val;
        public ListNode? next;
        public ListNode(int x)
        {
            val = x;
            this.next = null;
        }
    }

    public class ConvertBinaryNumberInALinkedListToInteger
    {
        public int Solve(ListNode head)
        {
            int counter = 0;
            int answer = 0;

            while (head != null)
            {
                answer = answer << 1 | head.val;
                counter++;
                head = head.next;
            }

            return answer;
        }
    }
}
