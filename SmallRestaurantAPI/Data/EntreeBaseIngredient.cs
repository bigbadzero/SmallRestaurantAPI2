using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Data
{
    public class EntreeBaseIngredient
    {
        public int ID { get; set; }

        [ForeignKey(nameof(Entree))]
        public int EntreeID { get; set; }
        public Entree Entree { get; set; }


        [ForeignKey(nameof(Ingredient))]
        public int IngredientID { get; set; }
        public Ingredient Ingredient { get; set; }


        public bool? isRequired { get; set; }
    }
}
