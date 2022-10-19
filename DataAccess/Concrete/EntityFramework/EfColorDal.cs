using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Repository.EntityFramework;
using Repository.Abstract;
using Models.Concrete;

namespace Repository.Concrete.EntityFramework
{
    public class EfColorDal : EfEntityRepositoryBase<Color, CarDatabaseContext>, IColorDal
    {

    }
}
