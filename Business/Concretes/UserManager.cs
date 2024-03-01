using AutoMapper;
using Business.Abstracts;
using Business.Request.User;
using Business.Response.User;
using DataAccess.Abstracs;
using Entity.Concretes;

namespace Business.Concretes;

public class UserManager : IUserService
{
    private readonly IUserRepository _userRepository;

    private readonly IMapper _mapper;

    public UserManager(IUserRepository userRepository, IMapper mapper)
    {
        _mapper = mapper;
        _userRepository = userRepository;
    }

    public async Task<CreateUserResponse> AddAsync(CreateUserRequest createUserRequest)
    {

        User user = _mapper.Map<User>(createUserRequest);
        await _userRepository.AddAsync(user);

        CreateUserResponse response = _mapper.Map<CreateUserResponse>(user);

        return response;  
    }

    public async Task<List<GetAllUserResponse>> GetAllAsync()
    {
        List<User> users = await _userRepository.GetAllAsync();
        List<GetAllUserResponse> responses = _mapper.Map<List<GetAllUserResponse>>(users);  //
        return responses;
    }

   
}
