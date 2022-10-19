using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Repository.EntityFramework;
using Repository.Abstract;
using Models.Concrete;
using Models.DTOs;
using Microsoft.EntityFrameworkCore;

namespace Repository.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarDatabaseContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarDatabaseContext context = new CarDatabaseContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.CarId equals b.BrandId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 CarName = c.CarName,
                                 BrandId = b.BrandId,
                                 BrandName = b.BrandName,
                                 DailyPrice = c.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}
