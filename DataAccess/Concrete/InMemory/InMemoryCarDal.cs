using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        
        

        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{CarId = 1,BrandId = 1,ColorId = 1,ModelYear = 1999,DailyPrice = 50,Description = "1999 model bir Fiat temiz."},
                new Car{CarId = 2,BrandId = 2,ColorId = 2,ModelYear = 2012,DailyPrice = 300,Description = "BMW model bir araba"},
                new Car{CarId = 3,BrandId = 1,ColorId = 3,ModelYear = 2016,DailyPrice = 400,Description = "2016 model bir Fiesta temiz."},
                new Car{CarId = 4,BrandId = 2,ColorId = 1,ModelYear = 2019,DailyPrice = 700,Description = "3.model bir araba"},
                new Car{CarId = 5,BrandId = 3,ColorId = 2,ModelYear = 1995,DailyPrice = 40,Description = "4.Model bir araba"},
                new Car{CarId = 6,BrandId = 3,ColorId = 3,ModelYear = 2020,DailyPrice = 1000,Description = "2.Model bir araba"},
                new Car{CarId = 7,BrandId = 3,ColorId = 1,ModelYear = 2021,DailyPrice = 1200,Description = "5.Model bir araba"}
            };

            


        }
                

        public void Add(Car entity)
        {
            _cars.Add(entity);
        }

        public void Delete(Car entity)
        {
            Car CarToDelete = _cars.SingleOrDefault(p => p.CarId == entity.CarId);
            _cars.Remove(CarToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            return _cars.SingleOrDefault(p=>p.CarId == 1); //İçine filter diyince hata veriyor..
            
            //return new Car { CarId = 1, BrandId = 1, ColorId = 1, ModelYear = 1999, DailyPrice = 50, Description = "1999 model bir Fiat temiz." };

        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            Console.WriteLine(filter);
            return _cars;
        }

        public List<CarDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            Car CarToUpdate = _cars.SingleOrDefault(p => p.CarId == entity.CarId);
            CarToUpdate.CarId = entity.CarId;
            CarToUpdate.BrandId = entity.BrandId;
            CarToUpdate.ColorId = entity.ColorId;
            CarToUpdate.ModelYear = entity.ModelYear;
            CarToUpdate.DailyPrice = entity.DailyPrice;
            CarToUpdate.Description = entity.Description;
        }
    }
}
