using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities {
    class Contract {
        public DateTime Date { get; set; }
        public double ValorPerHour { get; set; }
        public int Hour { get; set; }

        public Contract () {

        }

        public Contract(DateTime date, double valorPerHour, int hour) {
            Date = date;
            ValorPerHour = valorPerHour;
            Hour = hour;
        }

        public double TotalValue () {
            return ValorPerHour * Hour;
        }


    }

   
}
