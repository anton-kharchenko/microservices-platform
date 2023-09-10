using PlatformService.Data;
using PlatformService.Models;

namespace PlatformService.Mock;

public static class DbMockData
{
    public static void Population(IApplicationBuilder app)
    {
        using var serviceScope = app.ApplicationServices.CreateScope();
        SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
    }

    private static void SeedData(AppDbContext? context)
    {
        if (context != null && !context.Platforms.Any())
        {
            Console.WriteLine("-> Seeding data");
            context.Platforms.AddRange(
                new Platform { Name = "Dot Net", Publisher = "Microsoft", Cost = "Free" },
                new Platform { Name = "SQL Server", Publisher = "Microsoft", Cost = "Free" },
                new Platform { Name = "Kubernetes", Publisher = "Google", Cost = "Free" }
            );
            context.SaveChanges();
        }
        else
        {
            Console.WriteLine("-> We already have data");
        }
    }
}