using SmallRestaurantAPI.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.DTOs
{
    public class ItemAvailableAddonDTO
    {
        public int ID { get; set; }

        [ForeignKey(nameof(Ingredient))]
        public int IngredientID { get; set; }
        public Ingredient Ingredient { get; set; }


        [ForeignKey(nameof(Item))]
        public int ItemID { get; set; }
        public Item Item { get; set; }
    }
}
