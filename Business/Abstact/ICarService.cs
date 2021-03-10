using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstact
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetAllByCategoryId(int id);
        List<Car> GetByUnitPrice(int min, int max);
    }
}
