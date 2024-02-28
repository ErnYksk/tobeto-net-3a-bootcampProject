using Business.Abstracts;
using Business.Request.User;
using Business.Response.User;
using DataAccess.Abstracs;
using Entity.Concretes;

namespace Business.Concretes;

public class UserManager : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserManager(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<CreateUserResponse> AddAsync(CreateUserRequest createUserRequest)
    {
        User user=new User();
        user.FirstName = createUserRequest.FirstName;
        user.LastName = createUserRequest.LastName;
        user.Email = createUserRequest.EmailAddress;
        await _userRepository.AddAsync(user);
        CreateUserResponse createUserResponse = new CreateUserResponse();
        createUserResponse.FirstName= user.FirstName;
        createUserResponse.CreatedDate=user.CreatedDate;
        return createUserResponse;
    }

    public Task<List<User>> GetAll()
    {
        throw new NotImplementedException();
    }
}
