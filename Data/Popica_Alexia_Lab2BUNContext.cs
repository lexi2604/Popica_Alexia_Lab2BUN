using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Popica_Alexia_Lab2BUN.Models;

namespace Popica_Alexia_Lab2BUN.Data
{
    public class Popica_Alexia_Lab2BUNContext : DbContext
    {
        public Popica_Alexia_Lab2BUNContext (DbContextOptions<Popica_Alexia_Lab2BUNContext> options)
            : base(options)
        {
        }

        public DbSet<Popica_Alexia_Lab2BUN.Models.Book> Book { get; set; } = default!;

        public DbSet<Popica_Alexia_Lab2BUN.Models.Publisher> Publisher { get; set; }
    }
}
