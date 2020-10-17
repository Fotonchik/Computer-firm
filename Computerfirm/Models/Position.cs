using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;

namespace Computerfirm.Models
{
    public class Position
    {
        public long PositionID { get; set; }
        public string NamePosition { get; set; }
        public string Salary { get; set; }
        public string Duties { get; set; }
        public string Requirements { get; set; }
        public DbSet<Position> Positions { get; set; } 
    }
}
