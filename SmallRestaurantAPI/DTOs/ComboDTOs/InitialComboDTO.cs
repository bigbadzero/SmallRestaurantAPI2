using SmallRestaurantAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.DTOs
{
    public class InitialComboDTO: BaseItemRequirements
    {
        public int ComboNumber { get; set; }
        public bool? ComboSizeOverride { get; set; }
        public Entree EntreeMenuItem { get; set; }
        public Entree SideMenuItem { get; set; }

    }
}
