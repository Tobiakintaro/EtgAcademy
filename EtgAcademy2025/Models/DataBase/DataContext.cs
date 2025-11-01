using EtgAcademy2025.Models.DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtgAcademy2025.Models.DataBase
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DataContext()
        {
            
        }
        public DbSet<TransactionTb> TransactionTb { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {              
                optionsBuilder.UseSqlServer("Data Source=dbserver;database=EtgAcademy2025Db;MultipleActiveResultSets=True;trustServerCertificate=true; user id= sa; password = Welcome123");
            }
        }



    }
}
