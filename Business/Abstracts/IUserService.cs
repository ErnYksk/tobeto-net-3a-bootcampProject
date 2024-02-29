using Business.Request.User;
using Business.Response.User;
using Entity.Concretes;

namespace Business.Abstracts;

public interface IUserService
{
    Task <CreateUserResponse> AddAsync(CreateUserRequest createUserRequest);
    Task<List<GetAllUserResponse>> GetAllAsync();
}
