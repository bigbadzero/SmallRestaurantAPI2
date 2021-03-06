using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Data
{
    public class Entree 
    {
        [Key]
        public int ID { get; set; }
        [StringLength(50, ErrorMessage = "Cannot exceed 50 chars.")]
        public string Name { get; set; }
        [StringLength(250, ErrorMessage = "Cannot Exceed 250 characters.")]
        public string Description { get; set; }

        [ForeignKey(nameof(Category))]
        public  int CategoryID { get; set; }
        public  Category Category { get; set; }


        [ForeignKey(nameof(Size))]
        public int? SizeID { get; set; }
        public Size Size { get; set; }



        public virtual IList<EntreeBaseIngredient> EntreeBaseIngredients { get; set; }
        public virtual IList<EntreeAddon> EntreeAddons { get; set; }
        public virtual IList<EntreeSize> EntreeSizes { get; set; }
    }
}
