using AutoMapper;
using Business.Request.User;
using Business.Response.User;
using Entity.Concretes;

namespace Business.Profiles.Users
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles() {

            CreateMap<User, CreateUserRequest>().ReverseMap();
            CreateMap<User, CreateUserResponse>().ReverseMap();
        }
    }
}
