using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    
    internal class Order
    { 
        public int id { get; set; }
        public int user_id { get; set; }
        public int schedule_id { get; set; }
        public decimal price { get; set; }
        public int hall_number { get; set; }
        public string dtp { get; set; }
    }
}
