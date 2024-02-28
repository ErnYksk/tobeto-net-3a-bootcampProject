using Business.Abstracts;
using DataAccess.Abstracs;

namespace Business.Concretes;

public class ApplicationStateManager : IApplicationStateService
{
    private readonly IApplicationStateRepository _applicationStateRepository;

    public ApplicationStateManager(IApplicationStateRepository applicationStateRepository)
    {
        _applicationStateRepository = applicationStateRepository;
    }
}
