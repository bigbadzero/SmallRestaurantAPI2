using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Data
{
    public class SideSize
    {
        public int ID { get; set; }


        [ForeignKey(nameof(Entree))]
        public int SideID { get; set; }
        public Side Side { get; set; }


        [ForeignKey(nameof(Size))]
        public int SizeID { get; set; }
        public Size Size { get; set; }

    }
}
