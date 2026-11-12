using System.Linq.Expressions;

namespace MovieObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            OrderService service = new();
            service.ShowScreenings();

            string valinta = Console.ReadLine();

            switch (valinta)
            {
                case "1":
                    //osta lippu
                    service.BuyScreening(null);
                    break;
                case "2":
                    service.ShowScreenings();
                    break;
                default:
                    // code block
                    break;
            }

            if (valinta == "1")
            {
                //osta lippu
            }
            else if(valinta == "2")
            {
                //näytä näytökset
            }
        }
    }
}
