using System;
using System.Collections.Generic;
using System.Text;

namespace MovieObject
{
    internal class Receipt
    {
        public DateTime Time { get; set; }

        public decimal TotalSum { get; set; }

        public List<Screening> Screenings { get; set; }

        public Receipt(DateTime time, decimal totalSum, List<Screening> screenings)
        {

        }
    }
}
