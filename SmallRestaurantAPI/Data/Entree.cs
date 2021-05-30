using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Data
{
    public class Entree 
    {
        [Key]
        public int ID { get; set; }
        [StringLength(50, ErrorMessage = "Cannot exceed 50 chars.")]
        public string Name { get; set; }
        [StringLength(250, ErrorMessage = "Cannot Exceed 250 characters.")]
        public string Description { get; set; }

        [ForeignKey(nameof(Category))]
        public int CategoryID { get; set; }
        public Category Category { get; set; }

        //MenuItem Ingredients
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


        [ForeignKey(nameof(Ingredient6))]
        public int? Ingredient6ID { get; set; }
        public Ingredient Ingredient6 { get; set; }


        [ForeignKey(nameof(Ingredient7))]
        public int? Ingredient7ID { get; set; }
        public Ingredient Ingredient7 { get; set; }


        [ForeignKey(nameof(Ingredient8))]
        public int? Ingredient8ID { get; set; }
        public Ingredient Ingredient8 { get; set; }


        [ForeignKey(nameof(Ingredient9))]
        public int? Ingredient9ID { get; set; }
        public Ingredient Ingredient9 { get; set; }


        [ForeignKey(nameof(Ingredient10))]
        public int? Ingredient10ID { get; set; }
        public Ingredient Ingredient10 { get; set; }


        [ForeignKey(nameof(Ingredient11))]
        public int? Ingredient11ID { get; set; }
        public Ingredient Ingredient11 { get; set; }


        [ForeignKey(nameof(Ingredient12))]
        public int? Ingredient12ID { get; set; }
        public Ingredient Ingredient12 { get; set; }


        [ForeignKey(nameof(Ingredient13))]
        public int? Ingredient13ID { get; set; }
        public Ingredient Ingredient13 { get; set; }


        [ForeignKey(nameof(Ingredient14))]
        public int? Ingredient14ID { get; set; }
        public Ingredient Ingredient14 { get; set; }


        [ForeignKey(nameof(Ingredient15))]
        public int? Ingredient15ID { get; set; }
        public Ingredient Ingredient15 { get; set; }


        [ForeignKey(nameof(Ingredient16))]
        public int? Ingredient16ID { get; set; }
        public Ingredient Ingredient16 { get; set; }


        [ForeignKey(nameof(Ingredient17))]
        public int? Ingredient17ID { get; set; }
        public Ingredient Ingredient17 { get; set; }


        [ForeignKey(nameof(Ingredient18))]
        public int? Ingredient18ID { get; set; }
        public Ingredient Ingredient18 { get; set; }


        [ForeignKey(nameof(Ingredient19))]
        public int? Ingredient19ID { get; set; }
        public Ingredient Ingredient19 { get; set; }


        [ForeignKey(nameof(Condiment1))]
        public int? Condiment1ID { get; set; }
        public Ingredient Condiment1 { get; set; }


        [ForeignKey(nameof(Condiment2))]
        public int? Condiment2ID { get; set; }
        public Ingredient Condiment2 { get; set; }


        [ForeignKey(nameof(Condiment3))]
        public int? Condiment3ID { get; set; }
        public Ingredient Condiment3 { get; set; }


        [ForeignKey(nameof(Size))]
        public int SizeID { get; set; }
        public Size Size { get; set; }



    }
}
