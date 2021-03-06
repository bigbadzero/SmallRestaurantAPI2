using SmallRestaurantAPI.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.DTOs
{
    public class InitialEntreeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; }
        public CategoryDTO Category { get; set; }

        //public virtual IList<EntreeBaseIngredient> EntreeBaseIngredients { get; set; }
        //public virtual IList<EntreeAddon> EntreeAddons { get; set; }
    }
}
