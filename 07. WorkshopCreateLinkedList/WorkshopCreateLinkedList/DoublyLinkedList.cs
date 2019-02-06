namespace WorkshopCreateLinkedList
{
    using System;

    public class DoublyLinkedList
    {
        private class ListNode
        {
            public object Value { get; set; }

            public ListNode Next { get; set; }

            public ListNode Previous { get; set; }

            public ListNode(object value)
            {
                this.Value = value;
            }
        }

        private ListNode head;
        private ListNode tail;
        public int Count { get; set; }

        public object Head
        {
            get
            {
                IsValidateLinkedList();
                return this.head.Value;
            }
        }

        public object Tail
        {
            get
            {
                IsValidateLinkedList();
                return this.tail.Value;
            }
        }

        public void AddHead(object element)
        {
            ListNode newNode = new ListNode(element);
            if (this.Count == 0)
            {
                this.head = this.tail = newNode;
            }
            else
            {
                newNode.Next = this.head;
                this.head.Previous = newNode;
                this.head = newNode;
            }

            this.Count++;
        }

        public void AddTail(object element)
        {
            ListNode newNode = new ListNode(element);
            if (this.Count == 0)
            {
                this.head = this.tail = newNode;
            }
            else
            {
                newNode.Previous = this.tail;
                this.tail.Next = newNode;
                this.tail = newNode;
            }

            this.Count++;
        }

        public object RemoveHead()
        {
            IsValidateLinkedList();

            ListNode first = this.head;
            if (this.head == this.tail)
            {
                this.head = null;
                this.tail = null;
            }
            else
            {
                ListNode newHead = new ListNode(this.head.Next.Value);
                newHead.Previous = null;
                this.head.Next = null;
                this.head = newHead;
            }

            this.Count--;

            return first.Value;
        }

        public object RemoveTail()
        {
            IsValidateLinkedList();

            ListNode last = this.tail;
            if (this.tail == this.head)
            {
                this.tail = null;
                this.head = null;
            }
            else
            {
                ListNode newTail = new ListNode(this.tail.Previous.Value);
                this.tail.Previous = null;
                newTail.Next = null;
                this.tail = newTail;
            }

            this.Count--;
            return last.Value;
        }

        public object[] ToArrayLinkedList()
        {
            object[] arr = new object[this.Count];

            for (int i = 0; i < this.Count; i++)
            {
                arr[i] = this.head.Value;
                this.head = this.head.Next;
            }

            return arr;
        }

        public void ForEach(Action<object> action)
        {
            ListNode node = this.head;
            while (node != null)
            {
                action(node.Value);
                node = node.Next;
            }
        }

        public void IsValidateLinkedList()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Doubly Linked List is Empty");
            }
        }
    }
}
