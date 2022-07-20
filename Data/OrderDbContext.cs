using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    internal class OrderDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public OrderDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to mysql with connection string from app settings

            options.UseMySQL("Server=localhost;uid=root;pwd=123456789aA;Database=cinema");
        }

        public Microsoft.EntityFrameworkCore.DbSet<User> Orders { get; set; }
    }
}

