using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtgBank.Infrastructure.Data
{ //This is a design time factory for creating the DataContext instance during migrations or design-time operations. Not to be confused with the runtime factory used in the application , shalom.
    public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();           
            optionsBuilder.UseSqlServer("Server= DbServer; database=EtgBankDb;user id=sa;password=Welcome123;MultipleActiveResultSets=True;trustServerCertificate=true");
            return new DataContext(optionsBuilder.Options);
        }
    }

}
