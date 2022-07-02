using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleModule4Test1
{
    public class Shelf
    {
        private Book head;
        private Book tail;
        private int count;
        public int Count { get { return count; } }
        public Shelf()
        {
            head = null;
            tail = null;
            count = 0;
        }
        public void AddSpecialBook(string bookId)
        {
            Book tmp = new Book(bookId);
            if (Count == 0)
            {
                head = tmp;
                tail = tmp;
            }
            else
            {
                tmp.Next = head;
                head = tmp;
            }
            count++;
        }
        public void AddBook(string bookId)
        {
            
            if (Count == 0)
            {
                Book tmp = new Book(bookId);
                head = tmp;
                tail = tmp;
            }
            else
            {
                tail = new Book(bookId, tail);
            }
            count++;
        }
        public bool ReleaseBook(int index)
        {
            if (index >= Count || index < 0)
            {
                return false;
            }
            else if (index == 0)
            {
                head = head.Next;
                count--;
                return true;
            }
            else
            {
                Book before = head;
                Book now = head.Next;
                for (int i = 1; i < Count; i++)
                {
                    if (i == index)
                    {
                        before.Next = now.Next;
                        count--;
                        if (Object.Equals(now, tail))
                        {
                            tail = before;
                        }
                        return true;
                    }
                    before = before.Next;
                    now = now.Next;
                }
                return false;
            }

        }
        public bool ReleaseBook(string bookId)
        {
            if (head.BookId == bookId)
            {
                head = head.Next;
                count--;
                return true;
            }
            Book before = head;
            Book now = head.Next;
            for (int i = 1; i < Count; i++)
            {
                if (now.BookId == bookId)
                {
                    before.Next = now.Next;
                    count--;
                    if (Object.Equals(now, tail))
                    {
                        tail = before;
                    }
                    return true;
                }
                before = before.Next;
                now = now.Next;
            }
            return false;
        }
        public Book CheckBookIsPresent(string bookId)
        {
            if (Count == 0) return null;
            Book tmp = head;
            for (int i = 0; i < Count; i++)
            {
                if (tmp.BookId == bookId) return tmp;
                tmp = tmp.Next;
            }
            return null;
        }
        public StringBuilder ShelfInformation()
        {
            StringBuilder sb = new StringBuilder();
            if (Count == 0)
            {
                sb.Append("Shelf is empty!");
                return sb;
            }
            Book tmp = head;
            for (int i = 0; i < Count; i++)
            {
                sb.AppendLine(tmp.ToString());
                tmp = tmp.Next;
            }
            return sb;
        }
    }
}
