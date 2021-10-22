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
        public DbSet<PessoaFisica> PessoaFisica { get; set; }
        public DbSet<PessoaJuridica> PessoaJuridica { get; set; }
        public DbSet<AccountPFVm> AccountPFVm { get; set; }
    }
}
