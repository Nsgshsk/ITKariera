using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleModule4Test1
{
    public class Book
    {
        private string bookId;
        private Book next;
        public string BookId { get { return bookId; } }
        public Book Next
        {
            get { return next; }
            set { next = value; }
        }
        public Book(string bookId)
        {
            this.bookId = bookId;
            next = null;
        }
        public Book(string bookId, Book previous)
        {
            this.bookId = bookId;
            previous.next = this;
        }
        public override string ToString()
        {
            return $"book: {bookId}";
        }
    }
}
