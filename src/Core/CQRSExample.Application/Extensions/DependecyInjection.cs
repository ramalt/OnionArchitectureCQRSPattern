using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace CQRSExample.Application.Extensions;

public static class DependecyInjection
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(Assembly.GetExecutingAssembly());
    }
}