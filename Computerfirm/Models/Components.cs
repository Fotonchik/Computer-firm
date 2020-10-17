using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Computerfirm.Models
{
    public class Components
    {
        public long ComponentsID { get; set; }
        public int Price{ get; set; }

        public DateTime DataofIssue { get; set; }
        public DateTime WarrantyPeriod { get; set; }

        public string Described{ get; set; }
        public string Specificatrion { get; set; }
        public string CountryProduced{ get; set; }

        public DbSet<Staff> StaffID { get; set; }
        public DbSet<Components> Component { get; set; }
        public DbSet<TypesofСomponents> TypesofСomponents { get; set; }


    }
}
