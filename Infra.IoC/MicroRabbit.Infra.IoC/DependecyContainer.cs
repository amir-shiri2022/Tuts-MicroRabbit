using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Services;
using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Data.Repositories;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;

namespace MicroRabbit.Infra.IoC
{
    public static class DependecyContainer
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            //domain bus
            services.AddTransient<IEventBus, RabbitMQBus>();

            //application services
            services.AddTransient<IAccountService, AccountService>();
            
            //data
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddScoped<BankingDbContext>();
            return services;
        }
    }
}