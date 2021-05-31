using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Data
{
    public class SideAddon
    {
        public int ID { get; set; }

        [ForeignKey(nameof(Side))]
        public int SideID { get; set; }
        public Side Side { get; set; }

        [ForeignKey(nameof(Ingredient))]
        public int? IngredientID { get; set; }
        public Ingredient Ingredient { get; set; }

    }
}
