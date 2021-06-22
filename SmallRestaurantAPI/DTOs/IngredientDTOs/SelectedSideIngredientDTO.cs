using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.DTOs
{
    public class SelectedSideIngredientDTO
    {
        public int Id { get; set; }

        public int SelectedSideID { get; set; }

        public int IngredientId { get; set; }
    }
}
