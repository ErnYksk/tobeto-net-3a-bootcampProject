using Core.DataAccess.EntityFramework;
using DataAccess.Concretes.EntityFramework.Context;
using Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories;

public class ApplicationStateRepository : EfRepositoryBase<ApplicationState, int, BaseDbContext>
{
    public ApplicationStateRepository(BaseDbContext context) : base(context)
    {
    }
}
