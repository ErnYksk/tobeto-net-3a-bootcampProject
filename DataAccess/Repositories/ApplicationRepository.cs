using Core.DataAccess.EntityFramework;
using DataAccess.Abstracs;
using DataAccess.Concretes.EntityFramework.Context;
using Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories;

public class ApplicationRepository : EfRepositoryBase<Application, int, BaseDbContext>, IApplicationRepository
{
    public ApplicationRepository(BaseDbContext context) : base(context)
    {
    }
}
