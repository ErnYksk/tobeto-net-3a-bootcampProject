using AutoMapper;
using Business.Request.Application;
using Business.Responses.Applications;
using Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles.Applications;

public class MappingProfile:Profile
{
    public MappingProfile()
    {
        CreateMap<Application, CreateApplicationRequest>().ReverseMap();
        CreateMap<Application, DeleteApplicationRequest>().ReverseMap();
        CreateMap<Application, UpdateApplicationRequest>().ReverseMap();

        CreateMap<Application, CreateApplicationResponse>().ReverseMap();
        CreateMap<Application, DeleteApplicationResponse>().ReverseMap();
        CreateMap<Application, UpdateApplicationResponse>().ReverseMap();
        CreateMap<Application, GetAllApplicationResponse>().ReverseMap();
        CreateMap<Application, GetByIdApplicationResponse>().ReverseMap();
    }
}
