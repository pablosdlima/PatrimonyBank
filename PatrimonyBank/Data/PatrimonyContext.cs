using Microsoft.EntityFrameworkCore;
using PatrimonyBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatrimonyBank.Data
{
    public class PatrimonyContext : DbContext
    {
        public PatrimonyContext(DbContextOptions<PatrimonyContext> options) : base(options)
        {

        }
        public DbSet<Investidor> Investidor { get; set; }
    }
}
