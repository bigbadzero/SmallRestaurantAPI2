using SmallRestaurantAPI.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.DTOs
{
    public class MenuItemDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        [ForeignKey(nameof(Type))]
        public int TypeID { get; set; }
        public Type Type { get; set; }



        //list of item categories
        public virtual IList<ItemCategoryDTO> ItemCategories { get; set; }
        //list of base item ingredients
        public virtual IList<ItemBaseIngredientDTO> ItemBaseIngredients { get; set; }
        //list of available addons
        public virtual IList<ItemAvailableAddonDTO> ItemAvailableAddons { get; set; }
        //list of available sizes
        public virtual IList<ItemSizeDTO> ItemSizes { get; set; }
    }
}
