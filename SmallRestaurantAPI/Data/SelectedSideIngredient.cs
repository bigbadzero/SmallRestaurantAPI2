using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Data
{
    public class SelectedSideIngredient
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(SelectedSide))]
        public int SelectedSideID { get; set; }
        public SelectedSide SelectedSide { get; set; }


        [ForeignKey(nameof(Ingredient))]
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}
