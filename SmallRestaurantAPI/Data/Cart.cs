using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Data
{
    public class Cart
    {
        [Key]
        public int ID { get; set; }


        [ForeignKey(nameof(ApiUser))]
        [StringLength(450)]
        public string UserID { get; set; }
        public ApiUser ApiUser { get; set; }


        [ForeignKey(nameof(Entree))]
        public int? EntreeID { get; set; }
        public Entree Entree { get; set; }


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
