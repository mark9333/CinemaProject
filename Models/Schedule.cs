﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public class Schedule
    {
        public int id { get; set; }
        public string name { get; set; }
        public string time { get; set; }
        public string dayOfWeek { get; set; }
        public decimal price { get; set; }

        public Schedule()
        {

        }
    }
}
