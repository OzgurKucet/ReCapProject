using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarToDelete = _cars.SingleOrDefault(p=>p.CarId == car.CarId);
            _cars.Remove(CarToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByCategory(int BrandId)
        {
            return _cars.Where(p => p.BrandId == BrandId).ToList();
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            CarToUpdate.CarId = car.CarId;
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.ModelYear = car.ModelYear;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.Description = car.Description;

        }
    }
}
