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
        //template
        //private IGenericRepository<> _something;

        private IGenericRepository<Category> _categories;
        private IGenericRepository<Combo> _combos;
        private IGenericRepository<Condiment> _condiments;
        private IGenericRepository<Drink> _drinks;
        private IGenericRepository<Entree> _entrees;
        private IGenericRepository<EntreeAddon> _entreeAddons;
        private IGenericRepository<EntreeBaseIngredient> _entreeBaseIngredients;
        private IGenericRepository<EntreeSize> _entreeSizes;
        private IGenericRepository<Ingredient> _ingredients;
        private IGenericRepository<Side> _sides;
        private IGenericRepository<SideAddon> _sideAddons;
        private IGenericRepository<Size> _sizes;
        private IGenericRepository<CartItem> _cartItems;
        private IGenericRepository<ApiUser> _apiUser;
        private IGenericRepository<SelectedEntree> _selectedEntree;
        private IGenericRepository<SelectedEntreeIngredient> _selectedEntreeIngredient;
        private IGenericRepository<SelectedSide> _selectedSide;
        private IGenericRepository<SelectedSideIngredient> _selectedSideIngredient;
        
        private IGenericRepository<Item> _item;
        private IGenericRepository<Data.Type> _type;
        private IGenericRepository<ItemCategory> _itemCategory;
        private IGenericRepository<ItemBaseIngredient> _itemBaseIngredients;
        private IGenericRepository<ItemAvailableAddon> _itemAvailableAddon;
        private IGenericRepository<ItemSize> _itemSize;

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }

        //template
        //public IGenericRepository<> something => _something ?? new GenericRepository<>(_context);

        public IGenericRepository<Category> Categories => _categories ??= new GenericRepository<Category>(_context);
        public IGenericRepository<Combo> Combos => _combos ??= new GenericRepository<Combo>(_context);
        public IGenericRepository<Condiment> Condiments => _condiments ??= new GenericRepository<Condiment>(_context);
        public IGenericRepository<Drink> Drinks => _drinks ??= new GenericRepository<Drink>(_context);
        public IGenericRepository<Entree> Entrees => _entrees ??= new GenericRepository<Entree>(_context);
        public IGenericRepository<EntreeAddon> EntreeAddons => _entreeAddons ??= new GenericRepository<EntreeAddon>(_context);
        public IGenericRepository<EntreeBaseIngredient> EntreeBaseIngredients => _entreeBaseIngredients ??= new GenericRepository<EntreeBaseIngredient>(_context);
        public IGenericRepository<EntreeSize> EntreeSizes => _entreeSizes ??= new GenericRepository<EntreeSize>(_context);
        public IGenericRepository<Ingredient> Ingredients => _ingredients ??= new GenericRepository<Ingredient>(_context);
        public IGenericRepository<Side> Sides => _sides ??= new GenericRepository<Side>(_context);
        public IGenericRepository<SideAddon> SideAddons => _sideAddons ??= new GenericRepository<SideAddon>(_context);
        public IGenericRepository<Size> Sizes => _sizes ??= new GenericRepository<Size>(_context);
        public IGenericRepository<CartItem> CartItems => _cartItems ??= new GenericRepository<CartItem>(_context);
        public IGenericRepository<SelectedEntree> SelectedEntrees => _selectedEntree ??= new GenericRepository<SelectedEntree>(_context);
        public IGenericRepository<SelectedEntreeIngredient> SelectedEntreeIngredients => _selectedEntreeIngredient ??= new GenericRepository<SelectedEntreeIngredient>(_context);
        public IGenericRepository<SelectedSideIngredient> SelectedSideIngredients => _selectedSideIngredient ??= new GenericRepository<SelectedSideIngredient>(_context);
        public IGenericRepository<SelectedSide> SelectedSides => _selectedSide ??= new GenericRepository<SelectedSide>(_context);

        public IGenericRepository<Item> Items => _item ?? new GenericRepository<Item>(_context);
        public IGenericRepository<Data.Type> Types => _type ?? new GenericRepository<Data.Type>(_context);
        public IGenericRepository<ItemCategory> ItemCategories => _itemCategory ?? new GenericRepository<ItemCategory>(_context);
        public IGenericRepository<ItemBaseIngredient> ItemBaseIngredients => _itemBaseIngredients ?? new GenericRepository<ItemBaseIngredient>(_context);
        public IGenericRepository<ItemAvailableAddon> ItemAvailableAddons => _itemAvailableAddon ?? new GenericRepository<ItemAvailableAddon>(_context);
        public IGenericRepository<ItemSize> ItemSizes => _itemSize ?? new GenericRepository<ItemSize>(_context);



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
