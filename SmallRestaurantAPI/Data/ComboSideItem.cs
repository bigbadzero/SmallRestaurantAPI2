
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Data
{
    public class ComboSideItem
    {
        public int ID { get; set; }

        [ForeignKey(nameof(Type))]
        public int TypeID { get; set; }
        public Type Type { get; set; }


        [ForeignKey(nameof(Combo))]
        public int ComboID { get; set; }
        public Combo Combo { get; set; }


        [ForeignKey(nameof(Item))]
        public int ItemID { get; set; }
        public Item Item { get; set; }


    }
}
