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


        public DbSet<Category> Categories { get; set; }
        public DbSet<Combo> Combos { get; set; }
        public DbSet<Condiment> Condiments { get; set; }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Entree> Entrees { get; set; }
        public DbSet<EntreeAddon> EntreeAddons { get; set; }
        public DbSet<EntreeBaseIngredient> EntreeBaseIngredients { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Side> Sides { get; set; }
        public DbSet<SideAddon> SideAddons { get; set; }
        public DbSet<Size> Sizes { get; set; }
        


    }
}
