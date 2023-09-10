using PlatformService.Models;
using PlatformService.Repositories;

namespace PlatformService.Contracts;

public class PlatformRepository : IPlatformRepository
{
    public bool SaveChanges()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Platform> GetAllPlatforms()
    {
        throw new NotImplementedException();
    }

    public Platform GetPlatformByIf(string id)
    {
        throw new NotImplementedException();
    }

    public void CreatePlatform(Platform platform)
    {
        throw new NotImplementedException();
    }
}