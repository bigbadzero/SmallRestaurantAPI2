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

        [ForeignKey(nameof(Ingredient1))]
        public int? Ingredient1ID { get; set; }
        public Ingredient Ingredient1 { get; set; }
        [ForeignKey(nameof(Ingredient2))]
        public int? Ingredient2ID { get; set; }
        public Ingredient Ingredient2 { get; set; }


        [ForeignKey(nameof(Ingredient3))]
        public int? Ingredient3ID { get; set; }
        public Ingredient Ingredient3 { get; set; }


        [ForeignKey(nameof(Ingredient4))]
        public int? Ingredient4ID { get; set; }
        public Ingredient Ingredient4 { get; set; }


        [ForeignKey(nameof(Ingredient5))]
        public int? Ingredient5ID { get; set; }
        public Ingredient Ingredient5 { get; set; }

    }
}
