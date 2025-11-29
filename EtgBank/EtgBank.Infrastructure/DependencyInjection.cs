using EtgBank.Application;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace EtgBank.Infrastructure
{
    public static class DependencyInjection
    {

        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {

            services.AddScoped<IEmailService, EmailService>();


            //services.AddScoped(typeof(IDataRepository<>), typeof(DataRepository<>));
            //services.AddDbContext<DataContext>(options => options.UseSqlServer(configuration.GetConnectionString("ConnStr")));
            //Vespa.Payservice.Application.DependencyInjection.AddApplication(services);
            //Vespa.Common.Infrastructure.DependencyInjection.AddCommonInfrastructure(services, configuration);


            return services;
        }


    }
}
