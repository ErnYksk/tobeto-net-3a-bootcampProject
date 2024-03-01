using AutoMapper;
using Business.Request.Instructor;
using Business.Responses.Instructor;
using Entity.Concretes;

namespace Business.Profiles.Instructors;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Instructor, CreateInstructorRequest>().ReverseMap();
        CreateMap<Instructor, DeleteInstructorRequest>().ReverseMap();
        CreateMap<Instructor, UpdateInstructorRequest>().ReverseMap();

        CreateMap<Instructor, CreateInstructorResponse>().ReverseMap();
        CreateMap<Instructor, DeleteInstructorResponse>().ReverseMap();
        CreateMap<Instructor, UpdateInstructorResponse>().ReverseMap();
        CreateMap<Instructor, GetAllInstructorResponse>().ReverseMap();
        CreateMap<Instructor, GetByIdInstructorResponse>().ReverseMap();
    }
}
