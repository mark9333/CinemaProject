using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public class PlaceDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public PlaceDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to mysql with connection string from app settings

            options.UseMySQL("Server=localhost;uid=root;pwd=123456789aA;Database=cinema");
        }

        public Microsoft.EntityFrameworkCore.DbSet<Place> Places { get; set; }
    }
}
