using Microsoft.EntityFrameworkCore;
using EtgBank.Domain.Models.Entities;

namespace EtgBank.Infrastructure.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<TransactionTb> TransactionTb { get; set; }
        public DbSet<TierTb> TierTb { get; set; }
        public DbSet<CustomerTb> CustomerTb { get; set; }
        public DbSet<AccountTb> AccountTb { get; set; }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<TierTb>().ToTable("TierTb");
    modelBuilder.Entity<CustomerTb>().ToTable("CustomerTb");
    modelBuilder.Entity<AccountTb>().ToTable("AccountTb");
    modelBuilder.Entity<TransactionTb>().ToTable("TransactionTb");

    modelBuilder.Entity<AccountTb>()
        .HasOne<TierTb>()
        .WithMany()
        .HasForeignKey(a => a.TierId)
        .OnDelete(DeleteBehavior.Restrict);

    modelBuilder.Entity<AccountTb>()
        .HasOne<CustomerTb>()
        .WithMany()
        .HasForeignKey(a => a.CustomerId)
        .OnDelete(DeleteBehavior.Cascade);

    modelBuilder.Entity<TransactionTb>()
        .HasOne<AccountTb>()
        .WithMany()
        .HasForeignKey(t => t.AccountId)
        .OnDelete(DeleteBehavior.Restrict);
}

    }
}
