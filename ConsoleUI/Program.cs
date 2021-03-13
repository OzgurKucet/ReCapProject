using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.GetRentalDetails();

            if (result.Success == true)
            {
                foreach (var rental in result.Data)
                {
                    Console.WriteLine("RentId"+rental.RentId+" Name:" + rental.UserFirstName + "Car:" + " Price:" + rental.DailyPrice + "Date time" + rental.RentDate);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }


            //CarDetails();            
            //CarTest();

        }

        private static void CarDetails()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetProductDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + " / " + car.ColorName + " / " + car.DailyPrice + " / " + car.Description);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAllByCategoryId(4).Data)
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
