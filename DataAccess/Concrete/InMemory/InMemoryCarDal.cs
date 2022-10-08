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
                new Car{CarId=1,Brand="Audi",Color="Siyah",DailyPrice=150,Description="kiralık audi araç",ModelYear=2021},
                new Car{CarId=1,Brand="BMW",Color="Beyaz",DailyPrice=150,Description="kiralık BMW araç",ModelYear=2021},
                new Car{CarId=1,Brand="Honda",Color="Kırmızı",DailyPrice=150,Description="kiralık Honda araç",ModelYear=2019},
                new Car{CarId=1,Brand="Renault",Color="Mor",DailyPrice=150,Description="kiralık Renault araç",ModelYear=2020},
                new Car{CarId=1,Brand="Tesla",Color="Siyah",DailyPrice=150,Description="kiralık Tesla araç",ModelYear=2021}
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
            carToUpdate.Brand = car.Brand;
            carToUpdate.Color = car.Color;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
