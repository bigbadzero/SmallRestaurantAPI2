using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmallRestaurantAPI.Configurations.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Data
{
    public class DatabaseContext : IdentityDbContext<ApiUser>
    {
        public DatabaseContext(DbContextOptions options): base(options)
        {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new IngredientConfiguration());
            builder.ApplyConfiguration(new SizeConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new EntreeConfiguration());
            builder.ApplyConfiguration(new EntreeBaseIngredientConfiguration());
            builder.ApplyConfiguration(new EntreeAddonConfiguration());
            builder.ApplyConfiguration(new SideConfiguration());
            builder.ApplyConfiguration(new DrinkConfiguration());
            builder.ApplyConfiguration(new ComboConfiguration());
            builder.ApplyConfiguration(new CartItemStatusConfiguration());

            builder.ApplyConfiguration(new ItemConfiguration());
            builder.ApplyConfiguration(new TypeConfiguration());
            builder.ApplyConfiguration(new ItemCategoryConfiguration());
            builder.ApplyConfiguration(new ItemBaseIngredientConfiguration());
            builder.ApplyConfiguration(new ItemAvailableAddonConfiguration());
            builder.ApplyConfiguration(new ItemSizeConfiguration());
            builder.ApplyConfiguration(new ComboSideItemConfiguration());
            builder.ApplyConfiguration(new ComboDrinkItemConfiguration());

        }


        public DbSet<Category> Categories { get; set; }
        public DbSet<Combo> Combos { get; set; }
        public DbSet<Condiment> Condiments { get; set; }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Entree> Entrees { get; set; }
        public DbSet<EntreeAddon> EntreeAddons { get; set; }
        public DbSet<EntreeBaseIngredient> EntreeBaseIngredients { get; set; }
        public DbSet<EntreeSize> EntreeSizes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Side> Sides { get; set; }
        public DbSet<SideAddon> SideAddons { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet <CartItemStatus> CartItemStatuses { get; set; }
        public DbSet<SelectedEntree> SelectedEntrees { get; set; }
        public DbSet<SelectedEntreeIngredient> SelectedEntreeIngredients { get; set; }
        public DbSet<SelectedSide> SelectedSides { get; set; }
        public DbSet<SideBaseIngredient> SideBaseIngredients { get; set; }
        public DbSet<SideSize> SideSizes { get; set; }
        public DbSet<SelectedSideIngredient> SelectedSideIngredients { get; set; }


        public DbSet<Item> Items { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<ItemCategory> ItemCategories { get; set; }
        public DbSet<ItemBaseIngredient> ItemBaseIngredients { get; set; }
        public DbSet<ItemAvailableAddon> ItemAvailableAddons { get; set; }
        public DbSet<ItemSize> ItemSizes { get; set; }
        public DbSet<ComboSideItem> ComboSideItems { get; set; }
        public DbSet<ComboDrinkItem> ComboDrinkItems { get; set; }




    }
}
