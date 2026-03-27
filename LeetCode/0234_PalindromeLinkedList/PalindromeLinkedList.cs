namespace LeetCode._0234_PalindromeLinkedList
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

    public class PalindromeLinkedList
    {
        public bool Solve(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while (fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            ListNode prev = null;
            ListNode curr = slow.next;

            while (curr != null)
            {
                ListNode next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }

            // Not really necessary, we don't care about keeping the linked list intact
            //slow.next = prev;

            while (prev != null)
            {
                if (head.val != prev.val)
                {
                    return false;
                }

                head = head.next;
                prev = prev.next;
            }

            return true;
        }
    }
}
