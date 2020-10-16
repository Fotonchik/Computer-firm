using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;

namespace Computerfirm.Models
{
    public class Customers
    {
        public long CustomersID { get; set; }
        public string NameRank { get; set; }
        public string FullName { get; set; }
        public int Telephone { get; set; }
        public DbSet<Customers> Customer { get; set; }

    }
}
