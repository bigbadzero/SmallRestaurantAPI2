using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.DTOs
{
    public class CartItemDTO
    {

        public int ID { get; set; }

        public string UserID { get; set; }

        public virtual IList<SelectedEntreeDTO> SelectedEntrees { get; set; }

    }
}
