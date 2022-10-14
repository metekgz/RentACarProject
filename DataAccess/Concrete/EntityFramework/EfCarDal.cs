using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
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
                             select new CarDetailDto { CarId = c.CarId, DailyPrice = c.DailyPrice, BrandId = b.BrandId,BrandName=b.BrandName };
                return result.ToList();
            }
        }
    }
}
