using SmallRestaurantAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.DTOs
{
    public class EntreeOptionsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; }
        public int? SizeID { get; set; }
        public IList<EntreeBaseIngredientDTO> EntreeBaseIngredients { get; set; }
        public  IList<EntreeAddonDTO> EntreeAddons { get; set; }
        public  IList<EntreeSizesDTO> EntreeSizes { get; set; }


    }
}
