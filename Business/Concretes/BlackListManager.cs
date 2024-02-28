using Business.Abstracts;
using DataAccess.Abstracs;

namespace Business.Concretes;

public class BlackListManager : IBlackListService
{
    private readonly IBlackListRepository _blackListRepository;

    public BlackListManager(IBlackListRepository blackListRepository)
    {
        _blackListRepository = blackListRepository;
    }
}
