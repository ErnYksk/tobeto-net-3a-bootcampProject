using Business.Abstracts;
using DataAccess.Abstracs;

namespace Business.Concretes;

public class BootcampManager : IBootcampService
{
    private readonly IBootcampRepository _bootcampRepository;

    public BootcampManager(IBootcampRepository bootcampRepository)
    {
        _bootcampRepository = bootcampRepository;
    }

   
}
