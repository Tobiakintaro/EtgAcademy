

using Microsoft.EntityFrameworkCore;
using EtgBank.Domain.Models.Entities;


namespace EtgBank.Infrastructure.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<TransactionTb> TransactionTb { get; set; }
        public DbSet<TierTb> TierTb { get; set; }
        public DbSet<CustomerTb> CustomerTb { get; set; }
        public DbSet<AccountTb> AccountTb { get; set; }




    }
}
