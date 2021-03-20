/*using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        
        public List<RentalDetailDto> GetRentalDetails()
        {
            using(RentACarContext context = new RentACarContext())
            {

                var result = from ca in context.Cars
                             join re in context.Rentals
                             on ca.CarId equals re.CarId
                             join cu in context.Customers
                             on re.CustomerId equals cu.CustomerId
                             join us in context.Users
                             on cu.UserId equals us.UserId

                             select new RentalDetailDto { RentId = re.RentId, DailyPrice = ca.DailyPrice, UserFirstName = us.UserFirstName, UserLastName = us.UserLastName,RentDate = re.RentDate, ReturnDate = re.ReturnDate};
                             
                            
                             

                return result.ToList();
            }
        }
    }
}*/
