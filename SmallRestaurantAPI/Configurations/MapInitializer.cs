using AutoMapper;
using SmallRestaurantAPI.Data;
using SmallRestaurantAPI.DTOs;
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
            CreateMap<Combo, ComboOptionsDTO>().ReverseMap();
            CreateMap<Entree, InitialEntreeDTO>().ReverseMap();
            CreateMap<Side, InitialSideDTO>().ReverseMap();
            CreateMap<Drink, InitialDrinkDTO>().ReverseMap();
            CreateMap<Entree, EntreeOptionsDTO>().ReverseMap();
            CreateMap<Size, SizeDTO>().ReverseMap();
            CreateMap<EntreeBaseIngredient, EntreeBaseIngredientDTO>().ReverseMap();
            CreateMap<EntreeAddon, EntreeAddonDTO>().ReverseMap();
            CreateMap<EntreeSize, EntreeSizesDTO>().ReverseMap();
            CreateMap<Ingredient, IngredientDTO>().ReverseMap();
            CreateMap<ApiUser, UserDTO>().ReverseMap();
            CreateMap<CartItem, CartItemDTO>().ReverseMap();
            CreateMap<SelectedEntree, SelectedEntreeDTO>().ReverseMap();
            CreateMap<SelectedEntreeIngredient, SelectedEntreeDTO>();
            CreateMap<SelectedEntree, CartItem>().ReverseMap();
            CreateMap<SelectedEntreeIngredient, SelectedEntreeIngredientDTO>().ReverseMap();
            CreateMap<SelectedEntree, SelectedEntreeIngredient>().ReverseMap();
            CreateMap<SelectedSide, SelectedSideDTO>().ReverseMap();
            CreateMap<SideBaseIngredient, SideBaseIngredientDTO>().ReverseMap();
            CreateMap<SideAddon, SideAddonDTO>().ReverseMap();
            CreateMap<SideSize, SideSizesDTO>().ReverseMap();
            CreateMap<SelectedSideIngredient, SelectedSideIngredientDTO>().ReverseMap();

            CreateMap<Item, MenuItemDTO>().ReverseMap();
            CreateMap<Type, TypeDTO>().ReverseMap();
            CreateMap<ItemCategory, ItemCategoryDTO>().ReverseMap();
            CreateMap<ItemBaseIngredient, ItemBaseIngredientDTO>().ReverseMap();
            CreateMap<ItemAvailableAddon, ItemAvailableAddonDTO>().ReverseMap();
            CreateMap<ItemSize, ItemSizeDTO>().ReverseMap();
            CreateMap<ComboSideItem, ComboSideItemDTO>().ReverseMap();
            CreateMap<ComboDrinkItem, ComboDrinkItemDTO>().ReverseMap();
        }
    }
}
