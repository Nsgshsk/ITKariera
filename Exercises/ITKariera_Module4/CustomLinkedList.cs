using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITKariera_Module4
{
    public class CustomLinkedList<T>
    {
        class Node
        {
            private T element;
            private Node next;
            public T Element
            {
                get { return element; }
                set { element = value; }
            }
            public Node Next
            {
                get { return next; }
                set { next = value; }
            }
            public Node(T element, Node prevNode)
            {
                this.element = element;
                prevNode.Next = this;
            }
            public Node(T element)
            {
                this.element = element;
                next = null;
            }
        }

        private Node head;
        private Node tail;
        private int count;
        public int Count { get { return count; } }
        public T this[int index]
        {
            get
            {
                if (index >= Count || index < 0) return default(T);
                Node node = head;
                for (int i = 0; i < Count; i++)
                {
                    if (i == index)
                        return node.Element;
                    node = node.Next;
                }
                return default(T);
            }
            set
            {
                if (index >= Count || index < 0) ;
                else
                {
                    Node node = head;
                    for (int i = 0; i < Count; i++)
                    {
                        if (i == index)
                        {
                            node.Element = value;
                            break;
                        }
                        node = node.Next;
                    }
                }
            }
        }
        public CustomLinkedList()
        {
            head = null;
            tail = null;
            count = 0;
        }
        public void AddLast(T item)
        {
            if (head == null)
            {
                Node x = new Node(item);
                head = x;
                tail = x;
            }
            else
            {
                Node x = new Node(item, tail);
                tail = x;
            }
            count++;
        }
        public void AddFirst(T item)
        {
            if (head == null)
            {
                Node x = new Node(item);
                head = x;
                tail = x;
            }
            else
            {
                Node tmp = head;
                Node x = new Node(item);
                x.Next = head;
                head = x;
            }
            count++;
        }
        public void InsetAt(T item, int index)
        {
            if (index >= Count || index < 0) return;
            else if (index == 0)
            {
                Node tmp = head;
                head = new Node(item);
                head.Next = tmp;
                count++;
            }
            else if (index == Count - 1)
            {
                tail = new Node(item, tail);
            }
            else
            {
                Node prevNode = head;
                Node mid = head.Next;
                for (int i = 1; i <= index; i++)
                {
                    if (i == index)
                    {
                        Node tmp = new Node(item, prevNode);
                        tmp.Next = mid;
                        count++;
                        return;
                    }
                    prevNode = mid;
                    mid = mid.Next;
                }
            }
        }
        public void RemoveAt(int index)
        {
            if (index >= Count || index < 0) return;
            else if (index == 0)
            {
                head = head.Next;
                count--;
            }
            else
            {
                Node prevNode = head;
                Node mid = head.Next;
                for (int i = 1; i <= index; i++)
                {
                    if (i == index)
                    {
                        prevNode.Next = mid.Next;
                        count--;
                        if (Object.Equals(mid, tail))
                        {
                            tail = prevNode;
                        }
                        return;
                    }
                    prevNode = mid;
                    mid = mid.Next;
                }
            }
        }
        public void Remove(T item)
        {
            if (EqualityComparer<T>.Default.Equals(head.Element, item))
            {
                head = head.Next;
                count--;
            }
            else
            {
                Node prevNode = head;
                Node mid = head.Next;
                for (int i = 1; i < Count; i++)
                {
                    if (EqualityComparer<T>.Default.Equals(mid.Element, item))
                    {
                        prevNode.Next = mid.Next;
                        count--;
                        if (Object.Equals(mid, tail))
                        {
                            tail = prevNode;
                        }
                        return;
                    }
                    prevNode = mid;
                    mid = mid.Next;
                }
            }
        }
        public int IndexOf(T item)
        {
            Node now = head;
            for (int i = 0; i < Count; i++)
            {
                if (EqualityComparer<T>.Default.Equals(now.Element, item)) return i;
                now = now.Next;
            }
            return -1;
        }
        public bool Contains(T item)
        {
            int tmp = IndexOf(item);
            if (tmp < 0) return false;
            return true;
        }
        public void Clear()
        {
            head = null;
            tail = null;
        }
        public T First()
        {
            return head.Element;
        }
        public T Last()
        {
            return tail.Element;
        }
        public override string ToString()
        {
            if (Count == 0) return string.Empty;
            else
            {
                StringBuilder tmp = new StringBuilder();
                Node now = head;
                for (int i = 0; i < Count; i++)
                {
                    tmp.Append($"{now.Element} ");
                    now = now.Next;
                }
                return tmp.ToString().TrimEnd();
            }
        }
    }
}
