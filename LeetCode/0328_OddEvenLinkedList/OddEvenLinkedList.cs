namespace LeetCode._0328_OddEvenLinkedList
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

    public class OddEvenLinkedList
    {
        public ListNode Solve(ListNode head)
        {
            if (head == null || head.next == null)
                return head;

            ListNode evenHead = head.next;

            ListNode oddRunner = head;
            ListNode evenRunner = evenHead;

            while (oddRunner.next != null && oddRunner.next.next != null)
            {
                oddRunner.next = oddRunner.next.next;
                evenRunner.next = evenRunner.next.next;

                oddRunner = oddRunner.next;
                evenRunner = evenRunner.next;
            }

            oddRunner.next = evenHead;

            return head;
        }
    }
}
