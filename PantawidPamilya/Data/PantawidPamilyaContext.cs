#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PantawidPamilya._4ps;

namespace PantawidPamilya.Data
{
    public class PantawidPamilyaContext : DbContext
    {
        public PantawidPamilyaContext (DbContextOptions<PantawidPamilyaContext> options)
            : base(options)
        {
        }

        public DbSet<PantawidPamilya._4ps.Class> Class { get; set; }
    }
}
