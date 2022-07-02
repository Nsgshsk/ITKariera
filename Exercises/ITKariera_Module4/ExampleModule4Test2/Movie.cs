using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleModule4Test2
{
    public class Movie
    {
        private string title;
        private double rating;

        public string Title { get { return title; } }
        public double Rating { get { return rating; } }

        public Movie(string title, double rating)
        {
            this.title = title;
            this.rating = rating;
        }
        public override string ToString()
        {
            return $"Movie {title} is with {rating:F1} rating.";
        }
    }
}
