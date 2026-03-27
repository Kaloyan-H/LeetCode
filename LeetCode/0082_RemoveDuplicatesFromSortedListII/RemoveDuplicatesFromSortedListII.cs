using System.ComponentModel.Design;

namespace LeetCode._0082_RemoveDuplicatesFromSortedListII
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

    public class RemoveDuplicatesFromSortedListII
    {
        public ListNode Solve(ListNode head)
        {
            if (head == null || head.next == null)
                return head;

            ListNode dummy = new ListNode(0);
            dummy.next = head;
            ListNode curr = dummy;

            while (curr.next != null && curr.next.next != null)
            {
                if (curr.next.val == curr.next.next.val)
                {
                    int dup = curr.next.val;
                    while (curr.next != null && curr.next.val == dup)
                    {
                        curr.next = curr.next.next;
                    }
                }
                else
                {
                    curr = curr.next;
                }
            }

            return dummy.next;
        }
    }
}
