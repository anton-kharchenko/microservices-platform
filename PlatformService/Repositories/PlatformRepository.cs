using PlatformService.Contracts;
using PlatformService.Data;
using PlatformService.Models;

namespace PlatformService.Repositories;

public class PlatformRepository : IPlatformRepository
{
    private readonly AppDbContext _dbContext;

    public PlatformRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public bool SaveChanges()
    {
        return _dbContext.SaveChanges() >= 0;
    }

    public IEnumerable<Platform?> GetAllPlatforms()
    {
        return _dbContext.Platforms.ToList();
    }

    public Platform? GetPlatformById(int id)
    {
        return _dbContext.Platforms.FirstOrDefault(i => i.Id == id);
    }

    public void CreatePlatform(Platform platform)
    {
        ArgumentNullException.ThrowIfNull(platform);
        _dbContext.Platforms.Add(platform);
    }
}