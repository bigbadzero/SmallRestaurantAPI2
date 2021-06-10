using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.DTOs
{
    public class CartItemDTO
    {

        public UserDTO User { get; set; }

        public EntreeOptionsDTO Entree { get; set; }

    }
}
