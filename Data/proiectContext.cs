using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using proiect.Models;

namespace proiect.Data
{
    public class proiectContext : DbContext
    {
        public proiectContext (DbContextOptions<proiectContext> options)
            : base(options)
        {
        }

        public DbSet<proiect.Models.Book> Book { get; set; }

        public DbSet<proiect.Models.Publisher> Publisher { get; set; }

        public DbSet<proiect.Models.Category> Category { get; set; }
    }
}
