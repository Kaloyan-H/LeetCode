namespace LeetCode._1721_SwappingNodesInALinkedList
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

    public class SwappingNodesInALinkedList
    {
        public ListNode Solve(ListNode head, int k)
        {
            ListNode left;
            ListNode fast = head;

            for (int i = 1; i < k; i++)
            {
                fast = fast.next;
            }

            left = fast;

            ListNode slow = head;

            while (fast.next != null)
            {
                slow = slow.next;
                fast = fast.next;
            }

            int rightVal = slow.val;
            slow.val = left.val;
            left.val = rightVal;

            return head;
        }
    }
}
