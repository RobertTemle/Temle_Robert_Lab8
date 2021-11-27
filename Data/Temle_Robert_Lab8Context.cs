using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Temle_Robert_Lab8.Models;

namespace Temle_Robert_Lab8.Data
{
    public class Temle_Robert_Lab8Context : DbContext
    {
        public Temle_Robert_Lab8Context (DbContextOptions<Temle_Robert_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Temle_Robert_Lab8.Models.Book> Book { get; set; }

        public DbSet<Temle_Robert_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Temle_Robert_Lab8.Models.Category> Category { get; set; }
    }
}
