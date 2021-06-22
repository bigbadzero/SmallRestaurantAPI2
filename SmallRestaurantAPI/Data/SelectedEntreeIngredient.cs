using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Data
{
    public class SelectedEntreeIngredient
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(SelectedEntree))]
        public int SelectedEntreeID { get; set; }
        public  SelectedEntree SelectedEntree { get; set; }


        [ForeignKey(nameof(Ingredient))]
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}
