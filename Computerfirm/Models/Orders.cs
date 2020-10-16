using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;

namespace Computerfirm.Models
{
    public class Orders
    {
        public DateTime OrderData { get; set; }
        public DateTime DueData { get; set; }
        public int ShareofPrepayment { get; set; }
        public Boolean  PaymentMark { get; set; }
        public Boolean  ExecutionMark{ get; set; }
        public DateTime GeneralWarranttyPeriod { get; set; }
        public int TotalCost { get; set; }
        public DbSet<Customers> CustomerID { get; set; }


    }
}
