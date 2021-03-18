using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstact
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetAllByCategoryId(int id);
        IDataResult<List<Car>> GetByUnitPrice(int min, int max);
        IDataResult<List<CarDetailDto>> GetProductDetails();
        IDataResult<Car> GetById(int carId);
        IResult Add(Car car);
        IResult Update(Car car);

    }
}
