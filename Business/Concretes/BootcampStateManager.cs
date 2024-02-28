using Business.Abstracts;
using DataAccess.Abstracs;

namespace Business.Concretes;

public class BootcampStateManager : IBootcampStateService
{
    private readonly IBootcampStateRepository _stateRepository;

    public BootcampStateManager(IBootcampStateRepository stateRepository)
    {
        _stateRepository = stateRepository;
    }
}
