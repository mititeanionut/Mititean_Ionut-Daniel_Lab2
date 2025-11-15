using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mititean_Ionut_Daniel_Lab2.Models;

namespace Mititean_Ionut_Daniel_Lab2.Data
{
    public class Mititean_Ionut_Daniel_Lab2Context : DbContext
    {
        public Mititean_Ionut_Daniel_Lab2Context (DbContextOptions<Mititean_Ionut_Daniel_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Mititean_Ionut_Daniel_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Mititean_Ionut_Daniel_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Mititean_Ionut_Daniel_Lab2.Models.Author> Author { get; set; } = default!;
    }
}
