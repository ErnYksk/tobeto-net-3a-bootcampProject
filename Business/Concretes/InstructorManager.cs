using Business.Abstracts;
using DataAccess.Abstracs;
using Entity.Concretes;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Business.Concretes;

public class InstructorManager : IInstructorService
{

    private readonly IInstructorRepository _repository;

    public InstructorManager(IInstructorRepository instructorRepository)
    {
        _repository = instructorRepository;
    }

   
}
