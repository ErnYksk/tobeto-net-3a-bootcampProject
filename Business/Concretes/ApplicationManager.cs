using Business.Abstracts;
using DataAccess.Abstracs;

namespace Business.Concretes;

public class ApplicationManager : IApplicationService
{
    private readonly IApplicationRepository _applicationRepository;

    public ApplicationManager(IApplicationRepository applicationRepository)
    {
        _applicationRepository = applicationRepository;
    }
}
