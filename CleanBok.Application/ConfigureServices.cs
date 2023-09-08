using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CleanBok.Application;

public static class ConfigureServices
{
    public static IServiceCollection AddCleanBokApplicationServices(this IServiceCollection services, Assembly assembly)
    {
        services.AddMediatR(options =>
        {
            options.RegisterServicesFromAssemblies(assembly);
        });
        services.AddValidatorsFromAssembly(assembly);
        return services;
    }
}
