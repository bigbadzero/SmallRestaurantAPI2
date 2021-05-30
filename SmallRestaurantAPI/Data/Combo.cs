using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Data
{
    public class Combo : BaseItemRequirements
    {
        //using BaseItemRequirements
        public int ComboNumber { get; set; }

        public bool? ComboSizeOverride { get; set; }

        [ForeignKey(nameof(Category))]
        public int CategoryID { get; set; }
        public Category Category { get; set; }

        [ForeignKey(nameof(Entree))]
        public int EntreeID { get; set; }
        public Entree Entree { get; set; }

        [ForeignKey(nameof(Side))]
        public int SideID { get; set; }
        public Side Side { get; set; }

        [ForeignKey(nameof(Drink))]
        public int DrinkID { get; set; }
        public Drink Drink { get; set; }

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
