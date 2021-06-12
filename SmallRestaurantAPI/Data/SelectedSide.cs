using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Data
{
    public class SelectedSide
    {
        [Key]
        public int ID { get; set; }


        [ForeignKey(nameof(Side))]
        public int SideID { get; set; }
        public Side Side { get; set; }

        [Required]
        [ForeignKey(nameof(CartItem))]
        public int CartItemID { get; set; }
        public CartItem CartItem { get; set; }


        [ForeignKey(nameof(Size))]
        public int? SizeID { get; set; }
        public Size Size { get; set; }
    }
}
