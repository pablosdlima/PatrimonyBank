using Microsoft.EntityFrameworkCore;
using PatrimonyBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PatrimonyBank.ViewMoldels;

namespace PatrimonyBank.Data
{
    public class PatrimonyContext : DbContext
    {
        public PatrimonyContext(DbContextOptions<PatrimonyContext> options) : base(options)
        {

        }
        public DbSet<Investidor> Investidor { get; set; }
        public DbSet<PatrimonyBank.ViewMoldels.AccountPFVm> AccountPFVm { get; set; }
    }
}
