using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleModule4Test2
{
    public class VideoLibrary
    {
        private string name;
        private List<Movie> movies;

        public string Name { get { return name; } }
        public List<Movie> Movies { get { return movies; } }

        public VideoLibrary(string name)
        {
            this.name = name;
            movies = new List<Movie>();
        }
        public void AddMovie(string title, double rating)
        {
            movies.Add(new Movie(title, rating));
        }
        public double AverageRating()
        {
            //return movies.Average(e => e.Rating);
            double avg = 0; 
            foreach (var item in movies)
            {
                avg += item.Rating;
            }
            return Math.Round(avg / movies.Count, 1);
        }
        public List<string> GetMoviesByRating(double rating)
        {
            List<string> list = new List<string>();
            foreach (var item in movies)
            {
                if (item.Rating > rating)
                {
                    list.Add(item.Title);
                }
            }
            return list;
        }
        public List<Movie> SortByTitle()
        {
            //movies.OrderBy(e => e.Title);
            bool swap;
            do
            {
                swap = false;
                for (int i = 0; i < movies.Count - 1; i++)
                {
                    if (movies[i].Title[0] > movies[i + 1].Title[0])
                    {
                        var tmp = movies[i];
                        movies[i] = movies[i + 1];
                        movies[i + 1] = tmp;
                        swap = true;
                    }
                }
            } while (swap);
            return movies;
        }
        public List<Movie> SortByRating()
        {
            //movies.OrderByDecending(e => e.Rating);
            bool swap;
            do
            {
                swap = false;
                for (int i = 0; i < movies.Count - 1; i++)
                {
                    if (movies[i].Rating < movies[i + 1].Rating)
                    {
                        var tmp = movies[i];
                        movies[i] = movies[i + 1];
                        movies[i + 1] = tmp;
                        swap = true;
                    }
                }
            } while (swap);
            return movies;
        }
        public string[] ProvideInformationAboutAllMovies()
        {
            string[] list = new string[movies.Count];
            for (int i = 0; i < movies.Count; i++)
            {
                list[i] = movies[i].ToString();
            }
            return list;
        }
        public bool CheckMovieIsInVideoLibrary(string title)
        {
            foreach (var item in movies)
            {
                if (item.Title == title) return true;
            }
            return false;
        }
    }
}
