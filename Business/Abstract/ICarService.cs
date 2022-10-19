using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Models.Concrete;
using Models.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int carId);
        IResult Add(Car car);
        void Delete(Car car);
        void Update(Car car);
        IDataResult<List<CarDetailDto>> GetCarDetails();
    }
}
