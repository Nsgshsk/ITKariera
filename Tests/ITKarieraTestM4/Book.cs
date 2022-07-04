using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class Book
    {
        private string title;

        private double rating;

        public Book(string title, double rating)
        {

            this.title = title;
            this.rating = rating;

        }

        public string Title
        {

            get { return title; }

        }

        public double Rating
        {

            get { return rating; }

        }

        public override string ToString()
        {

            return $"Book {title} is with {rating:F1} rating.";

        }
    }
}
