using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Data
{
    public class CartItem
    {
        [Key]
        public int ID { get; set; }



        [StringLength(450)]
        public string UserID { get; set; }


        [ForeignKey(nameof(selectedEntree))]
        public int? SelectedEntreeID { get; set; }
        public SelectedEntree selectedEntree { get; set; }


        [ForeignKey(nameof(Combo))]
        public int? ComboID { get; set; }
        public Combo Combo { get; set; }


        [ForeignKey(nameof(Drink))]
        public int? DrinkID { get; set; }
        public Drink Drink { get; set; }


        [ForeignKey(nameof(Side))]
        public int? SideID { get; set; }
        public Side Side { get; set; }


    }
}
