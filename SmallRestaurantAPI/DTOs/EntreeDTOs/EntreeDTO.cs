using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.DTOs
{
    public class EntreeDTO
    {
        public int Id { get; set; }
        public int CategoryID { get; set; }
        public int? SizeID { get; set; }
    }
}
