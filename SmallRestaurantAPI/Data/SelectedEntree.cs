using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Data
{
    public class SelectedEntree
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey(nameof(Entree))]
        public int EntreeID { get; set; }
        public Entree Entree { get; set; }


        [ForeignKey(nameof(cartItem))]
        public int CartItemID { get; set; }
        public CartItem cartItem { get; set; }


        public int? SizeID { get; set; }



        public virtual IList<SelectedIngredient> SelectedEntreeIngredients { get; set; }


    }
}
