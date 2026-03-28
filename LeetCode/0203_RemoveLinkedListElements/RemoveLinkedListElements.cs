namespace LeetCode._0203_RemoveLinkedListElements
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

    public class RemoveLinkedListElements
    {
        public ListNode Solve(ListNode head, int val)
        {
            // INITIAL INTUITION APPROACH

            //ListNode sentinel = new ListNode(0);
            //sentinel.next = head;

            //ListNode curr = head;
            //ListNode prev = new ListNode(0);
            //prev.next = curr;

            //int stepCounter = 0;
            //int removedCounter = 0;

            //while (curr != null)
            //{
            //    if (curr.val == val)
            //    {
            //        if (stepCounter == removedCounter)
            //        {
            //            sentinel.next = curr.next;
            //        }

            //        prev.next = curr.next;
            //        removedCounter++;
            //    }
            //    else
            //    {
            //        prev = curr;
            //    }

            //    curr = curr.next;
            //    stepCounter++;
            //}

            //return sentinel.next;

            // SECOND APPROACH LOOKING ONE NODE HEAD

            ListNode sentinel = new ListNode(0);
            sentinel.next = head;

            ListNode curr = sentinel;

            while (curr.next != null)
            {
                if (curr.next.val == val)
                {
                    curr.next = curr.next.next;
                }
                else
                {
                    curr = curr.next;
                }
            }

            return sentinel.next;
        }
    }
}
