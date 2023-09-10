using Microsoft.EntityFrameworkCore;
using PlatformService.Contracts;
using PlatformService.Data;
using PlatformService.Repositories;

namespace PlatformService.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IPlatformRepository, PlatformRepository>();
    }

    public static void AddDb(this IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>(op =>
            op.UseInMemoryDatabase("InMem"));
    }
}