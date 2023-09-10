using PlatformService.Models;

namespace PlatformService.Contracts;

public interface IPlatformRepository
{
    bool SaveChanges();
    IEnumerable<Platform?> GetAllPlatforms();
    Platform? GetPlatformByIf(int id);
    void CreatePlatform(Platform platform);
}