namespace LeetCode._0141_LinkedListCycle
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

    public class LinkedListCycle
    {
        public bool Solve(ListNode head)
        {
            // INITIAL HASHSET APPROACH

            HashSet<ListNode> set = new HashSet<ListNode>();

            ListNode? dummy = head;

            while (dummy != null)
            {
                if (!set.Add(dummy))
                {
                    return true;
                }

                dummy = dummy.next;
            }

            return false;

            // SLOW/FAST APPROACH

            //ListNode? slow = head;
            //ListNode? fast = head;

            //while (fast != null && fast.next != null)
            //{
            //    slow = slow.next;
            //    fast = fast.next.next;

            //    if (slow == fast)
            //        return true;
            //}

            //return false;
        }
    }
}
