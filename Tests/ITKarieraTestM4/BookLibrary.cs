using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class BookLibrary
    {
        private string name;
        private List<Book> books;

        public BookLibrary(string name)
        {

            this.name = name;
            books = new List<Book>();

        }

        public string Name
        {

            get { return name; }

        }

        public List<Book> Books
        {

            get { return books; }

        }

        public void AddBook(string title, double rating)
        {

            books.Add(new Book(title, rating));

        }

        public double AverageRating()
        {
            double avg = 0;
            foreach (var item in books)
            {
                avg+= item.Rating;
            }
            return Math.Round(avg / books.Count, 1);
        }

        public List<string> GetBooksByRating(double rating)
        {
            List<string> tmp = new List<string>();
            foreach (var item in books)
            {
                if (item.Rating > rating) tmp.Add(item.Title);
            }
            return tmp;
        }

        public List<Book> SortByTitle()
        {
            bool swap;
            do
            {
                swap = false;
                for (int i = 0; i < books.Count - 1; i++)
                {
                    if (books[i].Title[0] > books[i + 1].Title[0])
                    {
                        var tmp = books[i + 1];
                        books[i + 1] = books[i];
                        books[i] = tmp;
                        swap = true;
                    }
                }
            } while (swap);
            return books;

        }

        public List<Book> SortByRating()
        {

            bool swap;
            do
            {
                swap = false;
                for (int i = 0; i < books.Count - 1; i++)
                {
                    if (books[i].Rating < books[i + 1].Rating)
                    {
                        var tmp = books[i + 1];
                        books[i + 1] = books[i];
                        books[i] = tmp;
                        swap = true;
                    }
                }
            } while (swap);
            return books;

        }

        public string[] ProvideInformationAboutAllBooks()
        {

            string[] tmp = new string[books.Count];
            for (int i = 0; i < books.Count; i++)
            {
                tmp[i] = books[i].ToString();
            }
            return tmp;

        }

        public bool CheckBookIsInBookLibrary(string title)
        {

            foreach (var item in books)
            {
                if (item.Title == title) return true;
            }
            return false;

        }
    }
}
