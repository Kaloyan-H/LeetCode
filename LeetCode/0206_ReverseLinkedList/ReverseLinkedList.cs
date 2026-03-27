namespace LeetCode._0206_ReverseLinkedList
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

    public class ReverseLinkedList
    {
        public ListNode? Solve(ListNode head)
        {
            ListNode? prev = null;
            ListNode? curr = head;

            while (curr != null)
            {
                ListNode? temp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = temp;
            }

            return prev;
        }
    }
}
