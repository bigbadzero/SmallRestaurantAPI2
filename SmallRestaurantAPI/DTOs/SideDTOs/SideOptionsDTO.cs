using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.DTOs
{
    public class SideOptionsDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? SizeID { get; set; }
        
        
        public IList<SideBaseIngredientDTO> SidebaseIngredients { get; set; }
        public IList<SideAddonDTO> SideAddons { get; set; }
        public IList<SideSizesDTO> SideSizes { get; set; }
    }
}
