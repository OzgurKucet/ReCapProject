using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryProductDal()
        {
            _cars = new List<Car> {
                new Car{CarId = 1,BrandId = 1,ColorId = 1,ModelYear = 1999,DailyPrice = 200,Description = "1999 model bir Fiesta temiz."},
                new Car{CarId = 2,BrandId = 2,ColorId = 2,ModelYear = 2012,DailyPrice = 200,Description = "2.model bir araba"},
                new Car{CarId = 3,BrandId = 1,ColorId = 4,ModelYear = 2016,DailyPrice = 200,Description = "2016 model bir Fiesta temiz."},
                new Car{CarId = 4,BrandId = 3,ColorId = 5,ModelYear = 2019,DailyPrice = 200,Description = "3.model bir araba"},
                new Car{CarId = 5,BrandId = 4,ColorId = 3,ModelYear = 1995,DailyPrice = 200,Description = "4.Model bir araba"},
                new Car{CarId = 6,BrandId = 2,ColorId = 7,ModelYear = 2020,DailyPrice = 200,Description = "2.Model bir araba"},
                new Car{CarId = 7,BrandId = 5,ColorId = 3,ModelYear = 2021,DailyPrice = 200,Description = "5.Model bir araba"}
            };
        }

        public void Add(Car car)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByCategory(int BrandId)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
