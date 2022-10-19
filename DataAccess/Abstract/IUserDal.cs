using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Repository;
using Models.Concrete;

namespace Repository.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
    }
}
