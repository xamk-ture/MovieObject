using System;
using System.Collections.Generic;
using System.Text;

namespace MovieObject
{
    public enum ShowRoom { SmallTheater1, BigScreen }

    internal class Screening
    {
        public decimal Price { get; set; }
        public DateTime Time { get; set; }
        public string Location { get; set; }
        public ShowRoom ShowRoom { get; set; }
        public Movie Movie { get; set; }

        public Screening(Movie movie, decimal price, DateTime time, string location, ShowRoom room)
        {
            Movie = movie;
            Price = price;
            Time = time;
            Location = location;
            ShowRoom = room;
        }

    }
}
