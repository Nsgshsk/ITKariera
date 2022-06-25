using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITKariera_Module4
{
    public class CustomLinkedList
    {
        class Node
        {
            private object element;
            private Node next;
            public object Element
            {
                get { return element; }
                set { element = value; }
            }
            public Node Next
            {
                get { return next; }
                set { next = value; }
            }
            public Node(object element, Node prevNode)
            {
                this.element = element;
                prevNode.next = this;
            }
            public Node(object element)
            {
                this.element = element;
                next = null;
            }
        }

        private Node head;
        private Node tail;
        private int count;
        public int Count { get { return count; } }
        public object this[int index]
        {
            get
            {
                if (index >= Count || index < 0) return null;
                Node node = head;
                for (int i = 0; i < Count; i++)
                {
                    if (i == index)
                        return node;
                    node = node.Next;
                }
                return null;
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
        public void Add(object item)
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
        public void InsetAt(object item, int index)
        {
            if (index >= Count || index < 0) return;
            else if (index == 0)
            {
                Node tmp = head;
                head = new Node(item, tmp);
                count++;
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
            if (index >= Count) return;
            else if (index == 0) head = head.Next;
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
                        return;
                    }
                    prevNode = mid;
                    mid = mid.Next;
                }
            }
        }
        public void Remove(object item)
        {
            if (head.Element == item) head = head.Next;
            else
            {
                Node prevNode = head;
                Node mid = head.Next;
                for (int i = 1; i < Count; i++)
                {
                    if (head.Element == item)
                    {
                        prevNode.Next = mid.Next;
                        count--;
                        return;
                    }
                    prevNode = mid;
                    mid = mid.Next;
                }
            }
        }
    }
}
