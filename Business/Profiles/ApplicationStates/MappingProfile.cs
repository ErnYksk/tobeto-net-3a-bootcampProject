using AutoMapper;
using Business.Request.ApplicationState;
using Business.Responses.ApplicationStates;
using Entity.Concretes;

namespace Business.Profiles.ApplicationStates;

public class MappingProfile:Profile
{
    public MappingProfile()
    {
        CreateMap<ApplicationState, CreateApplicationStateRequest>().ReverseMap();
        CreateMap<ApplicationState, DeleteApplicationStateRequest>().ReverseMap();
        CreateMap<ApplicationState, UpdateApplicationStateRequest>().ReverseMap();

        CreateMap<ApplicationState, CreateApplicationStateResponse>().ReverseMap();
        CreateMap<ApplicationState, DeleteApplicationStateResponse>().ReverseMap();
        CreateMap<ApplicationState, UpdateApplicationStateResponse>().ReverseMap();
        CreateMap<ApplicationState, GetAllApplicationStateResponse>().ReverseMap();
        CreateMap<ApplicationState, GetByIdApplicationStateResponse>().ReverseMap();
    }
}
