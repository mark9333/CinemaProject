using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public class Schedule
    {
        public int id { get; set; }
        public string day_of_projection { get; set; }
        public decimal price { get; set; }
        public string time_of_projection { get; set; }
        public string movie_name { get; set; }

        public Schedule()
        {

        }
    }
}
