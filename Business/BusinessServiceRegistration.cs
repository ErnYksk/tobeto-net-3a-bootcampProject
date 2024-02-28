using Business.Abstracts;
using Business.Concretes;
using Microsoft.Extensions.DependencyInjection;

namespace Business;


public static class BusinessServiceRegistration
{
    public static IServiceCollection AddBusinessService (this IServiceCollection services)
    {
        services.AddScoped<IUserService, UserManager>();
        services.AddScoped<IApplicantService, ApplicantManager>();
        services.AddScoped<IEmployeeService, EmployeeManager>();
        services.AddScoped<IInstructorService, InstructorManager>();
        services.AddScoped<IApplicationService, ApplicationManager>();
        services.AddScoped<IApplicationStateService, ApplicationStateManager>();
        services.AddScoped<IBootcampService, BootcampManager>();
        services.AddScoped<IBootcampStateService, BootcampStateManager>();
        services.AddScoped<IBlackListService, BlackListManager>();
        return services;
    }

}

