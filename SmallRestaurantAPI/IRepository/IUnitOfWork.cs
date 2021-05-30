using SmallRestaurantAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Combo> Combos { get; }
        IGenericRepository<Condiment> Condiments { get; }
        IGenericRepository<Drink> Drinks { get; }
        IGenericRepository<Ingredient> Ingredients { get; }
        IGenericRepository<MenuItem> MenuItems { get; }
        IGenericRepository<MenuItemType> MenuItemTypes { get; }

        Task Save();
    }
}
