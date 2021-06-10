using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.DTOs
{
    public class SelectedEntreeDTO
    {
        public int EntreeID { get; set; }
        public int CartItemID { get; set; }

        public int CategoryID { get; set; }
        public int? SizeID { get; set; }

        public IList<IngredientDTO> SelectedEntreeIngredients { get; set; }
    }
}
