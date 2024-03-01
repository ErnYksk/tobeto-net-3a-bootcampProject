using AutoMapper;
using Business.Request.Applicant;
using Business.Responses.Applicant;
using Entity.Concretes;

namespace Business.Profiles.Applicants;

public class MappingProfile:Profile
{
    public MappingProfile()
    {
        CreateMap<Applicant, CreateApplicantRequest>().ReverseMap();
        CreateMap<Applicant, DeleteApplicantRequest>().ReverseMap();
        CreateMap<Applicant, UpdateApplicantRequest>().ReverseMap();

        CreateMap<Applicant, CreateApplicantResponse>().ReverseMap();
        CreateMap<Applicant, DeleteApplicantResponse>().ReverseMap();
        CreateMap<Applicant, UpdateApplicantResponse>().ReverseMap();
        CreateMap<Applicant, GetAllApplicantResponse>().ReverseMap();
        CreateMap<Applicant, GetByIdApplicantResponse>().ReverseMap();
    }
}
