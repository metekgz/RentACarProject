using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Repository.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Repository.Concrete.EntityFramework;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarImageDal : EfEntityRepositoryBase<CarImage, CarDatabaseContext>, ICarImageDal
    {
    }
}
