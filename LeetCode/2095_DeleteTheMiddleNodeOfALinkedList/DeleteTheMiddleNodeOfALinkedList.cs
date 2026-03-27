namespace LeetCode._2095_DeleteTheMiddleNodeOfALinkedList
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

    public class DeleteTheMiddleNodeOfALinkedList
    {
        public ListNode Solve(ListNode head)
        {
            if (head.next == null)
                return null;

            ListNode? fast = head;
            ListNode slow = new ListNode(0);
            slow.next = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next!;
                fast = fast.next.next;
            }

            slow.next = slow.next!.next;

            return head;
        }
    }
}
