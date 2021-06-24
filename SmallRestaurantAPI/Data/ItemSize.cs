using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Data
{
    public class ItemSize
    {
        public int ID { get; set; }


        [ForeignKey(nameof(Item))]
        public int ItemID { get; set; }
        public Item Item { get; set; }


        [ForeignKey(nameof(Size))]
        public int SizeID { get; set; }
        public Size Size { get; set; }


    }
}
