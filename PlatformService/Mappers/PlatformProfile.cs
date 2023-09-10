using AutoMapper;
using PlatformService.Dto;
using PlatformService.Models;

namespace PlatformService.Mappers;

public class PlatformProfile : Profile
{
    public PlatformProfile()
    {
        CreateMap<Platform, PlatformReadDto>();
        CreateMap<PlatformCreateDto, Platform>();
    }
}