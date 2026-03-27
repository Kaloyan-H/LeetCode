namespace LeetCode._0024_SwapNodesInPairs
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

    public class SwapNodesInPairs
    {
        public ListNode Solve(ListNode head)
        {
            if (head == null || head.next == null)
                return head;

            ListNode dummyStart = head.next;
            ListNode? prev = null;

            while (head != null && head.next != null)
            {
                if (prev != null)
                {
                    prev.next = head.next;
                }

                prev = head;

                ListNode? nextNode = head.next.next;
                head.next.next = head;

                head.next = nextNode;
                head = nextNode;
            }

            return dummyStart;
        }
    }
}
