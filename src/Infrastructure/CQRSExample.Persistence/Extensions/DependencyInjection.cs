using CQRSExample.Application.Interfaces.Repository;
using CQRSExample.Persistence.Data;
using CQRSExample.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CQRSExample.Persistence.Extensions;

public static class DependencyInjection
{
    public static void AddPersistence(this IServiceCollection services)
    {
        services.AddDbContext<ApplicationDbContext>(options => options.UseInMemoryDatabase("InMemoryDb"));
        services.AddTransient<IProductRepository, ProductRepository>();

    }

}