﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetById(int id);
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
        List<CarDetailDto> GetCarDetails();
    }
}
