using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RP.Domain;

namespace RP.Data
{
    public class RPContext : DbContext
    {
        public RPContext (DbContextOptions<RPContext> options)
            : base(options)
        {
        }

        public DbSet<RP.Domain.Report> Report { get; set; } = default!;
    }
}
