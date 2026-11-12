namespace MovieObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Movie movie = new("Testi leffa", 250, Genre.Action);

            DateTime time = new(2026, 12, 12, 20, 00, 0);
            Screening screening = new(movie, 15, time, "Mikkeli", ShowRoom.BigScreen);

            List<Screening> theaterScreenings = new();
            theaterScreenings.Add(screening);

            //Valitaan näytös
            //Valitaan paikka
            //Maksetaan varaus
            //Saadaan kuitti
        }
    }
}
