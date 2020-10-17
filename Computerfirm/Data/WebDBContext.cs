using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Computerfirm.Models;

namespace WebDB.Models
{
    public class WebDBContext : DbContext
    {
        public WebDBContext (DbContextOptions<WebDBContext> options)
            : base(options)
        {
        }

        public DbSet<Computerfirm.Models.Staff> Staff { get; set; }

        public DbSet<Computerfirm.Models.TypesofСomponents> TypesofСomponents { get; set; }

        public DbSet<Computerfirm.Models.Services> Services { get; set; }

        public DbSet<Computerfirm.Models.Components> Components { get; set; }

        public DbSet<Computerfirm.Models.Customers> Customers { get; set; }

        public DbSet<Computerfirm.Models.Position> Position { get; set; }

        public DbSet<Computerfirm.Models.Orders> Orders { get; set; }
    }
}
