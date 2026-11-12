using System;
using System.Collections.Generic;
using System.Text;

namespace MovieObject
{
    public enum Genre { Horror = 1, Action = 2, Comedy = 3}

    internal class Movie
    {
        public string Title { get; set; }

        public int RunTime { get; set; }

        public Genre Genre { get; set; }

        public Movie(string title, int runtime, Genre genre)
        {
            Title = title;
            RunTime = runtime;
            Genre = genre;
        }
    }
}
