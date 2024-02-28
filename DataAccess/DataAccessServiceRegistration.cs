using DataAccess.Abstracs;
using DataAccess.Concretes.EntityFramework.Context;
using DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess;

public static class DataAccessServiceRegistration
{
    public static IServiceCollection AddDataAccessService(this IServiceCollection services, IConfiguration configuration)
    {

        services.AddDbContext<BaseDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("TobetoDotNet3ACS")));
       
        // nota ekle
        services.AddScoped<IUserRepository, UserRepository>();


        return services;
    }
}
