using Business.Abstracts;
using Business.Request.User;
using Business.Response.User;
using Entity.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<CreateUserResponse> AddAsync(CreateUserRequest user)
        {
          return await _userService.AddAsync(user);
        }

        [HttpGet]
        public async Task<List<GetAllUserResponse>> GetAll()
        {
            return await _userService.GetAllAsync();
        }
    }
}