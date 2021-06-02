using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.DTOs
{
    public class EntreeSizesDTO
    {
        public int ID { get; set; }
        public int EntreeID { get; set; }
        public int SizeID { get; set; }


        public SizeDTO Size { get; set; }
    }
}
