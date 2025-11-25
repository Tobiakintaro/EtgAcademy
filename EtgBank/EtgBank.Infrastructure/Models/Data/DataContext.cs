

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
            modelBuilder.Entity<TransactionTb>().ToTable("TransactionTb");
            modelBuilder.Entity<TierTb>().ToTable("TierTb");
            modelBuilder.Entity<CustomerTb>().ToTable("CustomerTb");
            modelBuilder.Entity<AccountTb>().ToTable("AccountTb");
            
            modelBuilder.Entity<CustomerTb>()
                .HasOne(c => c.Tier)
                .WithMany(t => t.Customers)
                .HasForeignKey(c => c.TierId)
                .OnDelete(DeleteBehavior.Restrict);
            
            modelBuilder.Entity<AccountTb>()
                .HasOne(a => a.Customer)
                .WithMany(c => c.Accounts)
                .HasForeignKey(a => a.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);
            
            modelBuilder.Entity<TransactionTb>()
                .HasOne(t => t.Account)
                .WithMany(a => a.Transactions)
                .HasForeignKey(t => t.AccountId)
                .OnDelete(DeleteBehavior.Cascade);
        }
        public DbSet<TransactionTb> TransactionTb { get; set; }
        public DbSet<TierTb> TierTb { get; set; }
        public DbSet<CustomerTb> CustomerTb { get; set; }
        public DbSet<AccountTb> AccountTb { get; set; }




    }
}
