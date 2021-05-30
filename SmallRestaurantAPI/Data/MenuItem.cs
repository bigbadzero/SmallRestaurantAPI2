using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Data
{
    public class MenuItem : BaseItemRequirements
    {
        //using BaseItemRequirements

        [ForeignKey(nameof(MenuItemType))]
        public int MenuItemTypeID { get; set; }
        public MenuItemType MenuItemType { get; set; }

        //MenuItem Ingredients
        [ForeignKey(nameof(BaseIngredient1))]
        public int? BaseIngredient1ID { get; set; }
        public Ingredient BaseIngredient1 { get; set; }

        [ForeignKey(nameof(BaseIngredient2))]
        public int? BaseIngredient2ID { get; set; }
        public Ingredient BaseIngredient2 { get; set; }

        [ForeignKey(nameof(BaseIngredient3))]
        public int? BaseIngredient3ID { get; set; }
        public Ingredient BaseIngredient3 { get; set; }

        [ForeignKey(nameof(BaseIngredient4))]
        public int? BaseIngredient4ID { get; set; }
        public Ingredient BaseIngredient4 { get; set; }

        [ForeignKey(nameof(BaseIngredient5))]
        public int? BaseIngredient5ID { get; set; }
        public Ingredient BaseIngredient5 { get; set; }

        [ForeignKey(nameof(BaseIngredient6))]
        public int? BaseIngredient6ID { get; set; }
        public Ingredient BaseIngredient6 { get; set; }

        [ForeignKey(nameof(BaseIngredient7))]
        public int? BaseIngredient7ID { get; set; }
        public Ingredient BaseIngredient7 { get; set; }

        [ForeignKey(nameof(BaseIngredient8))]
        public int? BaseIngredient8ID { get; set; }
        public Ingredient BaseIngredient8 { get; set; }

        [ForeignKey(nameof(BaseIngredient9))]
        public int? BaseIngredient9ID { get; set; }
        public Ingredient BaseIngredient9 { get; set; }

        [ForeignKey(nameof(BaseIngredient10))]
        public int? BaseIngredient10ID { get; set; }
        public Ingredient BaseIngredient10 { get; set; }

        [ForeignKey(nameof(BaseIngredient11))]
        public int? BaseIngredient11ID { get; set; }
        public Ingredient BaseIngredient11 { get; set; }

        [ForeignKey(nameof(BaseIngredient12))]
        public int? BaseIngredient12ID { get; set; }
        public Ingredient BaseIngredient12 { get; set; }

        [ForeignKey(nameof(BaseIngredient13))]
        public int? BaseIngredient13ID { get; set; }
        public Ingredient BaseIngredient13 { get; set; }

        [ForeignKey(nameof(BaseIngredient14))]
        public int? BaseIngredient14ID { get; set; }
        public Ingredient BaseIngredient14 { get; set; }

        [ForeignKey(nameof(BaseIngredient15))]
        public int? BaseIngredient15ID { get; set; }
        public Ingredient BaseIngredient15 { get; set; }

        [ForeignKey(nameof(BaseIngredient16))]
        public int? BaseIngredient16ID { get; set; }
        public Ingredient BaseIngredient16 { get; set; }

        [ForeignKey(nameof(BaseIngredient17))]
        public int? BaseIngredient17ID { get; set; }
        public Ingredient BaseIngredient17 { get; set; }

        [ForeignKey(nameof(BaseIngredient18))]
        public int? BaseIngredient18ID { get; set; }
        public Ingredient BaseIngredient18 { get; set; }

        [ForeignKey(nameof(BaseIngredient19))]
        public int? BaseIngredient19ID { get; set; }
        public Ingredient BaseIngredient19 { get; set; }

        //MenuItem Condiments
        [ForeignKey(nameof(Condiment1))]
        public int? Condiment1ID { get; set; }
        public Ingredient Condiment1 { get; set; }

        [ForeignKey(nameof(Condiment2))]
        public int? Condiment2ID { get; set; }
        public Ingredient Condiment2 { get; set; }

        [ForeignKey(nameof(Condiment3))]
        public int? Condiment3ID { get; set; }
        public Ingredient Condiment3 { get; set; }




    }
}
