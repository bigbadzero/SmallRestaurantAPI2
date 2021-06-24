using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Data
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        [ForeignKey(nameof(Type))]
        public int TypeID { get; set; }
        public Type Type { get; set; }


        
        //list of item categories
        public virtual IList<ItemCategory> ItemCategories { get; set; }
        //list of base item ingredients
        public virtual IList<ItemBaseIngredient> ItemBaseIngredients { get; set; }
        //list of available addons
        public virtual IList<ItemAvailableAddon> ItemAvailableAddons { get; set; }
        //list of available sizes
        public virtual IList<ItemSize> ItemSizes { get; set; }
    }
}
