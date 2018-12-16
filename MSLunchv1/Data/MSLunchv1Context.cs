using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MSLunchv1.Models;

namespace MSLunchv1.Data
{
    public class MSLunchv1Context : DbContext
    {
        public MSLunchv1Context (DbContextOptions<MSLunchv1Context> options)
            : base(options)
        {
        }

        public DbSet<MSLunchv1.Models.Student> Student { get; set; }

        public DbSet<MSLunchv1.Models.Table> Table { get; set; }
    }
}
