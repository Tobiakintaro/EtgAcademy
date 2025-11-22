using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace EtgBank.Application
{
    public static class DependencyInjection
    {

        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
          
         


            //services.AddScoped(typeof(IDataRepository<>), typeof(DataRepository<>));
            //services.AddDbContext<DataContext>(options => options.UseSqlServer(configuration.GetConnectionString("ConnStr")));
            //Vespa.Payservice.Application.DependencyInjection.AddApplication(services);
            //Vespa.Common.Infrastructure.DependencyInjection.AddCommonInfrastructure(services, configuration);
        

            return services;
        }


    }
}
