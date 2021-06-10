using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmallRestaurantAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Configurations.Entities
{
    public class EntreeBaseIngredientConfiguration : IEntityTypeConfiguration<EntreeBaseIngredient>
    {
        public void Configure(EntityTypeBuilder<EntreeBaseIngredient> builder)
        {
            builder.HasData(
                new EntreeBaseIngredient
                {
                    ID = 1,
                    EntreeID = 1,
                    IngredientID = 1,
                    isRequired = true
                },
                new EntreeBaseIngredient
                {
                    ID = 2,
                    EntreeID = 1,
                    IngredientID = 2,
                    isRequired = true
                },
                new EntreeBaseIngredient
                {
                    ID = 3,
                    EntreeID = 1,
                    IngredientID = 3,
                    isRequired = false
                },
                new EntreeBaseIngredient
                {
                    ID = 4,
                    EntreeID = 1,
                    IngredientID = 4,
                    isRequired = false
                },
                new EntreeBaseIngredient
                {
                    ID = 5,
                    EntreeID = 1,
                    IngredientID = 5,
                    isRequired = false
                },
                new EntreeBaseIngredient
                {
                    ID = 6,
                    EntreeID = 1,
                    IngredientID = 6,
                    isRequired = false
                },
                new EntreeBaseIngredient
                {
                    ID = 7,
                    EntreeID = 1,
                    IngredientID = 7,
                    isRequired = false
                },
                new EntreeBaseIngredient
                {
                    ID = 8,
                    EntreeID = 2,
                    IngredientID = 8,
                    isRequired = true
                },
                new EntreeBaseIngredient
                {
                    ID = 9,
                    EntreeID = 2,
                    IngredientID = 8,
                    isRequired = true
                },
                new EntreeBaseIngredient
                {
                    ID = 10,
                    EntreeID = 2,
                    IngredientID = 8,
                    isRequired = true
                },
                new EntreeBaseIngredient
                {
                    ID = 11,
                    EntreeID = 3,
                    IngredientID = 9,
                    isRequired = true
                },
                new EntreeBaseIngredient
                {
                    ID = 12,
                    EntreeID = 3,
                    IngredientID = 10,
                    isRequired = true
                },
                new EntreeBaseIngredient
                {
                    ID = 13,
                    EntreeID = 3,
                    IngredientID = 11,
                    isRequired = true
                },
                new EntreeBaseIngredient
                {
                    ID = 14,
                    EntreeID = 3,
                    IngredientID = 12,
                    isRequired = false
                }
                );
        }
    }
}
