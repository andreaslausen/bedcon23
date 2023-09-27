using MedifoxDan.PizzaOnline.Core.Application;
using MedifoxDan.PizzaOnline.Core.Application.Contracts.Adapters;
using MedifoxDan.PizzaOnline.Core.Application.Interfaces;
using MedifoxDan.PizzaOnline.Core.Application.Mappers;
using MedifoxDan.PizzaOnline.Core.Application.Services;
using MedifoxDan.PizzaOnline.Core.Domain.Interfaces;
using MedifoxDan.PizzaOnline.Persistence.Memory;
using Microsoft.Extensions.DependencyInjection;

namespace MedifoxDan.PizzaOnline.API
{
    public class BaseStartup
    {
        public virtual void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IUnitOfWorkFactory, UnitOfWorkFactory>();
            services.AddScoped<IDateTimeProvider, SystemDateTimeProvider>();

            services.AddScoped<IMenuService, MenuService>();
            services.AddScoped<IMenuMapper, MenuMapper>();

            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IOrderMapper, OrderMapper>();
        }
    }
}