
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Data
{
    internal class UserDbContext : DbContext 
    {
        public UserDbContext() 
            : base(System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString)
        { 

        }

        public DbSet<User> Users { get; set; }

    }
}
