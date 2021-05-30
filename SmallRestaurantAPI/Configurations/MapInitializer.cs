using AutoMapper;
using SmallRestaurantAPI.Data;
using SmallRestaurantAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Configurations
{
    public class MapInitializer : Profile
    {
        public MapInitializer()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Combo, InitialComboDTO>().ReverseMap();
        }
    }
}
