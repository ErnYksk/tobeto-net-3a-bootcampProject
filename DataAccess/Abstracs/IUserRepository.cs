using Core.DataAccess;
using Entity.Concretes;

namespace DataAccess.Abstracs;

public interface IUserRepository : IAsyncRepository<User,int>, IRepository<User,int>
{

}
