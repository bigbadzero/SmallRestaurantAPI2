using SmallRestaurantAPI.Data;
using SmallRestaurantAPI.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        private IGenericRepository<Combo> _combos;
        private IGenericRepository<Condiment> _condiments;
        private IGenericRepository<Drink> _drinks;
        private IGenericRepository<Ingredient> _ingredients;
        private IGenericRepository<MenuItem> _menuItems;
        private IGenericRepository<MenuItemType> _menuItemTypes;

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }

        public IGenericRepository<Combo> Combos => _combos ??= new GenericRepository<Combo>(_context);

        public IGenericRepository<Condiment> Condiments => _condiments ??= new GenericRepository<Condiment>(_context);

        public IGenericRepository<Drink> Drinks => _drinks ??= new GenericRepository<Drink>(_context);

        public IGenericRepository<Ingredient> Ingredients => _ingredients ??= new GenericRepository<Ingredient>(_context);

        public IGenericRepository<MenuItem> MenuItems => _menuItems ??= new GenericRepository<MenuItem>(_context);

        public IGenericRepository<MenuItemType> MenuItemTypes => _menuItemTypes ??= new GenericRepository<MenuItemType>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
