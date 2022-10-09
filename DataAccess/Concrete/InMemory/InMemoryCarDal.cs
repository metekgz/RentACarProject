using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=3,ColorId=1,DailyPrice=150,Description="kiralık audi araç",ModelYear=2021},
                new Car{CarId=1,BrandId=6,ColorId=2,DailyPrice=150,Description="kiralık BMW araç",ModelYear=2021},
                new Car{CarId=1,BrandId=3,ColorId=3,DailyPrice=150,Description="kiralık Honda araç",ModelYear=2019},
                new Car{CarId=1,BrandId=2,ColorId=3,DailyPrice=150,Description="kiralık Renault araç",ModelYear=2020},
                new Car{CarId=1,BrandId=3,ColorId=4,DailyPrice=150,Description="kiralık Tesla araç",ModelYear=2021}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(p => p.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
