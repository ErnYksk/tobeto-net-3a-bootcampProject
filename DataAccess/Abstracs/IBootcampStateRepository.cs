using Core.DataAccess;
using Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracs;

public interface IBootcampStateRepository:IAsyncRepository<BootcampState,int>
{
}
