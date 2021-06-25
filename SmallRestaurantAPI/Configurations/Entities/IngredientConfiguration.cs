using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmallRestaurantAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Configurations.Entities
{
    public class IngredientConfiguration: IEntityTypeConfiguration<Ingredient>
    {
        public void Configure(EntityTypeBuilder<Ingredient> builder)
        {
            builder.HasData(
                new Ingredient
                {
                    ID = 1,
                    Name = "Hamburger bun"
                },
                new Ingredient
                {
                    ID = 2,
                    Name = "Hamburger Patty"
                },
                new Ingredient
                {
                    ID = 3,
                    Name = "Sliced Cheese"
                },
                new Ingredient
                {
                    ID = 4,
                    Name = "Ketchup"
                },
                new Ingredient
                {
                    ID = 5,
                    Name = "Mustard"
                },
                new Ingredient
                {
                    ID = 6,
                    Name = "Onion"
                },
                new Ingredient
                {
                    ID = 7,
                    Name = "Pickle"
                },
                new Ingredient
                {
                    ID = 8,
                    Name = "Chicken Finger"
                },
                new Ingredient
                {
                    ID = 9,
                    Name = "Pizza Crust"
                },
                new Ingredient
                {
                    ID = 10,
                    Name = "Pizza Sauce"
                },
                new Ingredient
                {
                    ID = 11,
                    Name = "Shredded Cheese"
                },
                new Ingredient
                {
                    ID = 12,
                    Name = "Pepperoni"
                },
                new Ingredient
                {
                    ID = 13,
                    Name = "Bacon"
                },
                new Ingredient
                {
                    ID = 14,
                    Name = "Buffalo Sauce"
                },
                new Ingredient
                {
                    ID = 15,
                    Name = "Pineapple"
                },
                new Ingredient
                {
                    ID = 16,
                    Name = "French Fries"
                },
                new Ingredient
                {
                    ID = 17,
                    Name = "Onion Rings"
                },
                new Ingredient
                {
                    ID = 18,
                    Name = "Coke"
                }
                );
        }
    }
}
