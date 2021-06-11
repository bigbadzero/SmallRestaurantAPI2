using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.DTOs
{
    public class SelectedIngredientDTO
    {
        public int Id { get; set; }

        public int SelectedEntreeID { get; set; }

        public int IngredientId { get; set; }
    }
}
