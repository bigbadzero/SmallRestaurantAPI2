using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.DTOs
{
    public class SideBaseIngredientDTO
    {
        public int ID { get; set; }
        public int SideID { get; set; }
        public int IngredientID { get; set; }
        public bool? isRequired { get; set; }

        public IngredientDTO Ingredient { get; set; }
    }
}
