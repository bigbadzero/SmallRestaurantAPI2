using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.DTOs
{
    public class SelectedEntreeIngredientDTO
    {
        public int Id { get; set; }

        public int SelectedEntreeID { get; set; }

        public int IngredientId { get; set; }
    }
}
