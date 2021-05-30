using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options): base(options)
        {}

        public DbSet<Combo> Combos { get; set; }
        public DbSet<Condiment> Condiments { get; set; }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Entree> MenuItems { get; set; }
        public DbSet<MenuItemType> MenuItemTypes { get; set; }
    }
}
