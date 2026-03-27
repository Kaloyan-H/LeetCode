namespace LeetCode._0019_RemoveNthNodeFromEndOfList
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

    public class RemoveNthNodeFromEndOfList
    {
        public ListNode Solve(ListNode head, int n)
        {
            if (head.next == null) return null;

            ListNode fast = head;

            for (int i = 0; i < n; i++)
            {
                fast = fast.next;
            }

            ListNode dummy = new ListNode(0);
            dummy.next = head;
            ListNode slow = dummy;

            while (fast != null)
            {
                slow = slow.next;
                fast = fast.next;
            }

            slow.next = slow.next.next;

            return dummy.next;
        }
    }
}
