﻿using SmallRestaurantAPI.Data;
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

        private IGenericRepository<Category> _categories;
        private IGenericRepository<Combo> _combos;
        private IGenericRepository<Condiment> _condiments;
        private IGenericRepository<Drink> _drinks;
        private IGenericRepository<Ingredient> _ingredients;
        private IGenericRepository<Entree> _entrees;
        private IGenericRepository<Side> _sides;

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }

        public IGenericRepository<Category> Categories => _categories ??= new GenericRepository<Category>(_context);

        public IGenericRepository<Combo> Combos => _combos ??= new GenericRepository<Combo>(_context);

        public IGenericRepository<Condiment> Condiments => _condiments ??= new GenericRepository<Condiment>(_context);

        public IGenericRepository<Drink> Drinks => _drinks ??= new GenericRepository<Drink>(_context);

        public IGenericRepository<Ingredient> Ingredients => _ingredients ??= new GenericRepository<Ingredient>(_context);

        public IGenericRepository<Entree> Entrees => _entrees ??= new GenericRepository<Entree>(_context);
        public IGenericRepository<Side> Sides => _sides ??= new GenericRepository<Side>(_context);

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
