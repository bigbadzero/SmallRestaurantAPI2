using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.DTOs
{
    public class SelectedSideDTO
    {
        public int SideID { get; set; }
        public int? SizeID { get; set; }

        public IList<SelectedSideIngredientDTO> SelectedSideIngredients { get; set; }
    }
}
