using AutoMapper;
using Business.Request.BlackList;
using Business.Responses.Blacklists;
using Entity.Concretes;

namespace Business.Profiles.Blacklists;

public class MappingProfile:Profile
{
    public MappingProfile()
    {
        CreateMap<BlackList, CreateBlackListRequest>().ReverseMap();
        CreateMap<BlackList, DeleteBlackListRequest>().ReverseMap();
        CreateMap<BlackList, UpdateBlackListRequest>().ReverseMap();

        CreateMap<BlackList, CreateBlacklistResponse>().ReverseMap();
        CreateMap<BlackList, DeleteBlacklistResponse>().ReverseMap();
        CreateMap<BlackList, UpdateBlacklistResponse>().ReverseMap();
        CreateMap<BlackList, GetAllBlacklistResponse>().ReverseMap();
        CreateMap<BlackList, GetByIdBlacklistResponse>().ReverseMap();
    }
}
