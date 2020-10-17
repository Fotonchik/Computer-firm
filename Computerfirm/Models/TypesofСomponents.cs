using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;

namespace Computerfirm.Models
{
    public class TypesofСomponents
    {
        public long TypesofСomponentsID { get; set; }
        public string NameTypesofComponents { get; set; }
        public string Description { get; set; }
        public DbSet<TypesofСomponents> TypesofСomponent { get; set; }

    }
}
