using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmallRestaurantAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Configurations.Entities
{
    public class EntreeAddonConfiguration : IEntityTypeConfiguration<EntreeAddon>
    {
        public void Configure(EntityTypeBuilder<EntreeAddon> builder)
        {
            builder.HasData(
                new EntreeAddon
                {
                    ID = 1,
                    EntreeID = 1,
                    IngredientID = 13
                },
                new EntreeAddon
                {
                    ID = 2,
                    EntreeID = 2,
                    IngredientID = 14
                },
                new EntreeAddon
                {
                    ID = 3,
                    EntreeID = 3,
                    IngredientID = 15
                }
                );
        }
    }
}
