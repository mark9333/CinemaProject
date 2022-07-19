
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Data
{
    internal class UserDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        

        public UserDbContext()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to mysql with connection string from app settings
           
            options.UseMySQL("Server=localhost;uid=root;pwd=123456789aA;Database=cinema");
        }

        public Microsoft.EntityFrameworkCore.DbSet<User> Users { get; set; }

    }
}
