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
        IGenericRepository<Ingredient> Ingredients { get; }
        IGenericRepository<Entree> Entrees { get; }
        IGenericRepository<Side> Sides { get; }
        IGenericRepository<Size> Sizes { get; }

        Task Save();
    }
}
