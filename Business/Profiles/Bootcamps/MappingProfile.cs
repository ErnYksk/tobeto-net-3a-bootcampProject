using AutoMapper;
using Business.Request.Bootcamp;
using Business.Responses.Bootcamps;
using Entity.Concretes;

namespace Business.Profiles.Bootcamps;

public class MappingProfile:Profile
{
    public MappingProfile()
    {
        CreateMap<Bootcamp, CreateBootcampRequest>().ReverseMap();
        CreateMap<Bootcamp, DeleteBootcampRequest>().ReverseMap();
        CreateMap<Bootcamp, UpdateBootcampRequest>().ReverseMap();

        CreateMap<Bootcamp, CreateBootcampResponse>().ReverseMap();
        CreateMap<Bootcamp, DeleteBootcampResponse>().ReverseMap();
        CreateMap<Bootcamp, UpdateBootcampResponse>().ReverseMap();
        CreateMap<Bootcamp, GetAllBootcampResponse>().ReverseMap();
        CreateMap<Bootcamp, GetByIdBootcampResponse>().ReverseMap();
    }
}
