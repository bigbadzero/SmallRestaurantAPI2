using SmallRestaurantAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Category> Categories { get; }
        IGenericRepository<Combo> Combos { get; }
        IGenericRepository<Condiment> Condiments { get; }
        IGenericRepository<Drink> Drinks { get; }
        IGenericRepository<Entree> Entrees { get; }
        IGenericRepository<EntreeAddon> EntreeAddons  {get;}
        IGenericRepository<EntreeBaseIngredient> EntreeBaseIngredients  {get;}
        IGenericRepository<EntreeSize> EntreeSizes  {get;}
        IGenericRepository<Ingredient> Ingredients { get; }
        IGenericRepository<Side> Sides { get; }
        IGenericRepository<SideAddon> SideAddons { get; }
        IGenericRepository<Size> Sizes { get; }
        IGenericRepository<CartItem> CartItems { get; }
        IGenericRepository<SelectedEntree> SelectedEntrees { get; }
        IGenericRepository<SelectedIngredient> SelectedIngredients { get; }

        Task Save();
    }
}
