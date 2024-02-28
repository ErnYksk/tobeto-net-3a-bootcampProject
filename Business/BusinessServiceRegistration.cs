using Business.Abstracts;
using Business.Concretes;
using Microsoft.Extensions.DependencyInjection;

namespace Business;


public static class BusinessServiceRegistration
{
    public static IServiceCollection AddBusinessService (this IServiceCollection services)
    {
        services.AddScoped<IUserService,UserManager>();
        return services;
    }

}

