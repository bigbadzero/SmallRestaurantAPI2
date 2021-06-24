using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmallRestaurantAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Configurations.Entities
{
    public class ItemBaseIngredientConfiguration : IEntityTypeConfiguration<ItemBaseIngredient>
    {
        public void Configure(EntityTypeBuilder<ItemBaseIngredient> builder)
        {
            builder.HasData(
                new ItemBaseIngredient
                {
                    ID = 1,
                    ItemID = 1,
                    IngredientID = 1,
                    isRequired = true
                },
                new ItemBaseIngredient
                {
                    ID = 2,
                    ItemID = 1,
                    IngredientID = 2,
                    isRequired = true
                },
                new ItemBaseIngredient
                {
                    ID = 3,
                    ItemID = 1,
                    IngredientID = 3,
                    isRequired = false
                },
                new ItemBaseIngredient
                {
                    ID = 4,
                    ItemID = 1,
                    IngredientID = 4,
                    isRequired = false
                },
                new ItemBaseIngredient
                {
                    ID = 5,
                    ItemID = 1,
                    IngredientID = 5,
                    isRequired = false
                },
                new ItemBaseIngredient
                {
                    ID = 6,
                    ItemID = 1,
                    IngredientID = 6,
                    isRequired = false
                },
                new ItemBaseIngredient
                {
                    ID = 7,
                    ItemID = 1,
                    IngredientID = 7,
                    isRequired = false
                },
                new ItemBaseIngredient
                {
                    ID = 8,
                    ItemID = 2,
                    IngredientID = 1,
                    isRequired = true
                },
                new ItemBaseIngredient
                {
                    ID = 9,
                    ItemID = 2,
                    IngredientID = 2,
                    isRequired = true
                },
                new ItemBaseIngredient
                {
                    ID = 10,
                    ItemID = 2,
                    IngredientID = 4,
                    isRequired = false
                },
                new ItemBaseIngredient
                {
                    ID = 11,
                    ItemID = 2,
                    IngredientID = 5,
                    isRequired = false
                },
                new ItemBaseIngredient
                {
                    ID = 12,
                    ItemID = 2,
                    IngredientID = 6,
                    isRequired = false
                },
                new ItemBaseIngredient
                {
                    ID = 13,
                    ItemID = 2,
                    IngredientID = 7,
                    isRequired = false
                }

                );
        }
    }
}
