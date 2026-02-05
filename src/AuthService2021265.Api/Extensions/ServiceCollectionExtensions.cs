using AuthService2021265.Domain.Interface;
using AuthService2021265.Persistence.Data;
using AuthService2021265.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using AuthService2021265.Application.Interface;
using AuthService2021265.Application.Services;

namespace AuthService2021265.Api.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options => 
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"))
                .UseSnakeCaseNamingConvention());
        
            services.AddScoped<UserRepository, UserRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();

            services.AddHealthChecks();

            return services;
    }

    public static IServiceCollection AddApiDocumentation(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        return services;
    }

}