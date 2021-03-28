﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        public IDataResult<List<Car>> GetAll();
        public IDataResult<Car> GetById(int id);

        public IDataResult<List<CarDetailsDto>> GetCarDetails();
        public IResult Add(Car car);
        public IResult Delete(Car car);
        public IResult Update(Car car);
    }
}
