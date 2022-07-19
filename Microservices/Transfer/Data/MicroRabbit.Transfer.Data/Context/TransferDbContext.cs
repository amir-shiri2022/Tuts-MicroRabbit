using MicroRabbit.Banking.Domain.Models;
using MicroRabbit.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Data.Context
{
    public class TransferDbContext : DbContext
    {
        public DbSet<TransferLog> TransferLogs { get; set; }
        public TransferDbContext(DbContextOptions<TransferDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
