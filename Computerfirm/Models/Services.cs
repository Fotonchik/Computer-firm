using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;

namespace Computerfirm.Models
{
    public class Services
    {
        public long ServicesID { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public DbSet<Services> Service { get; set; }
    }
}
