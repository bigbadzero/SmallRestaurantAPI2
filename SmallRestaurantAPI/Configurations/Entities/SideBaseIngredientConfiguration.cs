using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmallRestaurantAPI.Data;

namespace SmallRestaurantAPI.Configurations.Entities
{
    public class SideBaseIngredientConfiguration : IEntityTypeConfiguration<SideBaseIngredient>
    {
        public void Configure(EntityTypeBuilder<SideBaseIngredient> builder)
        {
            builder.HasData(
                new SideBaseIngredient
                {
                    ID = 1,
                    SideID = 1,
                    IngredientID = 16,
                    isRequired = true
                },
                new SideBaseIngredient
                {
                    ID = 2,
                    SideID = 2,
                    IngredientID = 17,
                    isRequired = true
                }
                );
        }
    }
}
