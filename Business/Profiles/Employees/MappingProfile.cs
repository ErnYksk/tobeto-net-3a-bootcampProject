using AutoMapper;
using Business.Request.Employee;
using Business.Responses.Employee;
using Entity.Concretes;

namespace Business.Profiles.Employees;

public class MappingProfile:Profile
{
    public MappingProfile()
    {
        CreateMap<Employee, CreateEmployeeRequest>().ReverseMap();
        CreateMap<Employee, DeleteEmployeeRequest>().ReverseMap();
        CreateMap<Employee, UpdateEmployeeRequest>().ReverseMap();

        CreateMap<Employee, CreateEmployeeResponse>().ReverseMap();
        CreateMap<Employee, DeleteEmployeeResponse>().ReverseMap();
        CreateMap<Employee, UpdateEmployeeResponse>().ReverseMap();
        CreateMap<Employee, GetAllEmployeeResponse>().ReverseMap();
        CreateMap<Employee, GetByIdEmployeeResponse>().ReverseMap();
    }
}
