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

public class BlackListRepository : EfRepositoryBase<BlackList, int, BaseDbContext>, IBlackListRepository
{
    public BlackListRepository(BaseDbContext context) : base(context)
    {
    }
}
