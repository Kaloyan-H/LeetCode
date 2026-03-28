namespace LeetCode._0707_DesignLinkedList
{
    public class DesignLinkedList
    {
        public int Length { get { return _length; } }

        private ListNode? _head;
        private ListNode? _tail;
        private int _length;

        public DesignLinkedList()
        {
            _head = null;
            _tail = null;
            _length = 0;
        }

        public int Get(int index)
        {
            if (_length == 0 || index >= _length || index < 0)
                return -1;

            if (index == 0)
                return _head.val;

            if (index == _length - 1)
                return _tail.val;

            ListNode runner = _head;

            for (int i = 0; i < index; i++)
            {
                runner = runner.next;
            }

            return runner.val;
        }

        public void AddAtHead(int val)
        {
            if (_head == null)
            {
                ListNode newNode = new ListNode(val);
                _head = newNode;
                _tail = newNode;
                _length++;
                return;
            }

            ListNode? temp = _head;
            _head = new ListNode(val);
            _head.next = temp;

            _length++;
        }

        public void AddAtTail(int val)
        {
            if (_head == null)
            {
                ListNode newNode = new ListNode(val);
                _head = newNode;
                _tail = newNode;
                _length++;
                return;
            }

            _tail.next = new ListNode(val);
            _tail = _tail.next;

            _length++;
        }

        public void AddAtIndex(int index, int val)
        {
            if (index > _length || index < 0)
                return;

            if (index == 0)
            {
                this.AddAtHead(val);
                return;
            }

            if (index == _length)
            {
                this.AddAtTail(val);
                return;
            }

            ListNode? runner = new ListNode(0);
            runner.next = _head;

            for (int i = 0; i < index; i++)
            {
                runner = runner.next;
            }

            ListNode? next = runner.next;
            runner.next = new ListNode(val);
            runner.next.next = next;

            _length++;
        }

        public void DeleteAtIndex(int index)
        {
            if (_length == 0 || index >= _length || index < 0)
                return;

            if (index == 0)
            {
                if (_head == _tail)
                {
                    _head = null;
                    _tail = null;
                    _length--;
                    return;
                }

                _head = _head.next;
                _length--;
                return;
            }

            ListNode runner = new ListNode(0);
            runner.next = _head;

            for (int i = 0; i < index; i++)
            {
                runner = runner.next;
            }

            runner.next = runner.next.next;

            if (runner.next == null)
                _tail = runner;

            _length--;
        }

        private class ListNode
        {
            public int val;
            public ListNode? next;
            public ListNode(int x)
            {
                val = x;
                this.next = null;
            }
        }
    }
}
