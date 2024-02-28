using Core.DataAccess;
using Entity.Concretes;

namespace DataAccess.Abstracs;

public interface IBlackListRepository : IAsyncRepository<BlackList, int>, IRepository<BlackList, int>
{
}
