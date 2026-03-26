namespace LeetCode._0083_RemoveDuplicatesFromSortedList
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

    public class RemoveDuplicatesFromSortedList
    {
        public ListNode? Solve(ListNode head)
        {
            // INITIAL APPROACH

            //if (head == null)
            //    return head;

            //ListNode dummy = head;

            //while (dummy.next != null)
            //{
            //    if (dummy.val == dummy.next.val)
            //    {
            //        ListNode? nextNext = dummy.next.next;

            //        if (nextNext == null)
            //        {
            //            dummy.next = null;
            //            break;
            //        }

            //        dummy.next = nextNext;
            //        continue;
            //    }

            //    dummy = dummy.next;
            //}

            //return head;

            // CLEANER APPROACH, SECOND TRY

            if (head == null)
                return head;

            ListNode? current = head;

            while (current != null)
            {
                ListNode? runner = current.next;

                while (runner != null && runner.val == current.val)
                {
                    runner = runner.next;
                }

                current.next = runner;
                current = current.next;
            }

            return head;
        }
    }
}
