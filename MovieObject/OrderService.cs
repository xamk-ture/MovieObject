using System;
using System.Collections.Generic;
using System.Text;

namespace MovieObject
{
    internal class OrderService
    {
        private List<Screening> _screenings { get; set; } = new();

        //Osta näytös
        //Näytä mitä näytöksiä
        //Anna kuitti
        //Varmista, että paikka on vapaana

        public OrderService()
        {
            Movie movie = new("Testi leffa", 250, Genre.Horror);
            Movie movie2 = new("Matrix", 250, Genre.Action);

            DateTime time = new(2026, 12, 12, 20, 00, 0);
            Screening screening = new(movie, 15, time, "Mikkeli", ShowRoom.BigScreen);
            _screenings.Add(screening);

            _screenings.Add(new Screening(movie2, 15, time, "Mikkeli", ShowRoom.SmallTheater1));
        }

        public void ShowScreenings()
        {

            foreach (var screening in _screenings)
            {
                Console.WriteLine($"Elokuva: {screening.Movie.Title}, Aika: {screening.Time}, Hinta: {screening.Price}, Genre: {screening.Movie.Genre.ToString()}");
            }
            
        }

        public Receipt BuyScreening(Screening screening)
        {
            Console.WriteLine($"Näytös maksaa {screening.Price}");
            Console.WriteLine("Anna rahat");

            //jos raha summa ei ole tarpeeksi, kerro että maksu epäonnistui
            //haluatko jatkaa vai poistua, kysymys

            //Jos maksu ok palauta true

            return new Receipt(DateTime.Now, 123, new List<Screening>());
        }

    }
}
