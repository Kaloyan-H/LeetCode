namespace LeetCode._2130_MaximumTwinSumOfALinkedList
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

    public class MaximumTwinSumOfALinkedList
    {
        public int Solve(ListNode head)
        {
            ListNode slow = head;
            ListNode? fast = head;

            while (fast != null /*&& fast.next != null*/) // Unnecessary since we are guaranteed an even number of nodes
            {
                slow = slow.next!;
                fast = fast.next!.next;
            }

            ListNode? prev = null;
            ListNode curr = slow;

            while (curr != null)
            {
                ListNode? next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }

            int largestSum = 0;

            while (prev != null)
            {
                largestSum = Math.Max(largestSum, head.val + prev.val);
                head = head.next!;
                prev = prev.next;
            }

            return largestSum;
        }
    }
}
