using PlatformService.Models;

namespace PlatformService.Repositories;

public interface IPlatformRepository
{
    bool SaveChanges();
    IEnumerable<Platform> GetAllPlatforms();
    Platform GetPlatformByIf(string id);
    void CreatePlatform(Platform platform);
}