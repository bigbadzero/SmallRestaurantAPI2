using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Data
{
    public class Side
    {
        [Key]
        public int ID { get; set; }

        [StringLength(50, ErrorMessage = "Cannot exceed 50 chars.")]
        public string Name { get; set; }

        [StringLength(250, ErrorMessage = "Cannot Exceed 250 characters.")]
        public string Description { get; set; }

        [ForeignKey(nameof(Size))]
        public int? SizeID { get; set; }
        public Size Size { get; set; }

        public virtual IList<SideBaseIngredient> SideBaseIngredients { get; set; }
        public virtual IList<SideAddon> SideAddons { get; set; }
        public virtual IList<SideSize> SideSizes { get; set; }
        
    }
}
