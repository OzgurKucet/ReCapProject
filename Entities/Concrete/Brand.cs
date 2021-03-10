using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //Marka
    public class Brand : IEntity  
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }

    }
}
