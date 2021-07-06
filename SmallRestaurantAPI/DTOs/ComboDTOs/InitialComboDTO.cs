using SmallRestaurantAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.DTOs
{
    public class InitialComboDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ComboNumber { get; set; }
        public int EntreeID { get; set; }

        public virtual IList<ComboSideItemDTO> ComboSideItems { get; set; }

        public virtual IList<ComboDrinkItemDTO> ComboDrinkItems { get; set; }
    }
}
