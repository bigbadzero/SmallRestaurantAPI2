using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Data
{
    public class SideBaseIngredient
    {
        public int ID { get; set; }

        [ForeignKey(nameof(Side))]
        public int SideID { get; set; }
        public Side Side { get; set; }

        [ForeignKey(nameof(Ingredient))]
        public int IngredientID { get; set; }
        public virtual Ingredient Ingredient { get; set; }

        public bool? isRequired { get; set; }
    }
}
