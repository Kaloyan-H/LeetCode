namespace LeetCode._0876_MiddleOfTheLinkedList
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

    public class MiddleOfTheLinkedList
    {
        public ListNode Solve(ListNode head)
        {
            ListNode slow = head;
            ListNode? fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next!;
                fast = fast.next.next;
            }

            return slow;
        }
    }
}
