using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.DTOs
{
    public class SideAddonDTO
    {
        public int ID { get; set; }
        public int SideID { get; set; }
        public string IngredientName { get; set; }
        public int IngredientID { get; set; }


        public IngredientDTO Ingredient { get; set; }
    }
}
