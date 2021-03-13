using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalDetailDto : IDto
    {

        public int RentId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public int DailyPrice { get; set; }
        public DateTime? RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }


    }
}
