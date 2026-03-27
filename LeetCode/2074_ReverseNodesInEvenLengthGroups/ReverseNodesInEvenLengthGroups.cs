namespace LeetCode._2074_ReverseNodesInEvenLengthGroups
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

    public class ReverseNodesInEvenLengthGroups
    {
        public ListNode Solve(ListNode head)
        {
            // INITIAL INTUITION APPROACH

            int counter = 1;

            ListNode prefix = new ListNode(0);
            prefix.next = head;
            ListNode? suffix = head.next;

            if (suffix == null)
                return head;

            while (prefix.next != null)
            {
                int groupCounter = 0;

                ListNode first = prefix.next;
                ListNode runner = prefix;

                while (groupCounter < counter && runner.next != null)
                {
                    runner = runner.next;
                    groupCounter++;
                }

                suffix = runner.next;

                if (groupCounter % 2 == 0)
                {
                    ListNode prev = null;
                    ListNode curr = first;

                    for (int i = 0; i < groupCounter; i++)
                    {
                        ListNode next = curr.next;
                        curr.next = prev;
                        prev = curr;
                        curr = next;
                    }

                    prefix.next = prev;
                    first.next = curr;
                    prefix = first;
                }
                else
                {
                    prefix = runner;
                }

                counter++;
            }

            return head;
        }
    }
}
