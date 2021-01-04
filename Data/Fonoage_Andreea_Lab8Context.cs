using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Fonoage_Andreea_Lab8.Models;

namespace Fonoage_Andreea_Lab8.Data
{
    public class Fonoage_Andreea_Lab8Context : DbContext
    {
        public Fonoage_Andreea_Lab8Context (DbContextOptions<Fonoage_Andreea_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Fonoage_Andreea_Lab8.Models.Book> Book { get; set; }
    }
}
