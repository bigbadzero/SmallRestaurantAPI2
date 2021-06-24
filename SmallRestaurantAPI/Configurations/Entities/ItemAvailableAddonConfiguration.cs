using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmallRestaurantAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Configurations.Entities
{
    public class ItemAvailableAddonConfiguration : IEntityTypeConfiguration<ItemAvailableAddon>
    {
        public void Configure(EntityTypeBuilder<ItemAvailableAddon> builder)
        {
            builder.HasData(
                new ItemAvailableAddon
                {
                    ID = 1,
                    ItemID = 1,
                    IngredientID = 13
                },
                new ItemAvailableAddon
                {
                    ID = 2,
                    ItemID = 2,
                    IngredientID = 13
                }
                );
        }
    }
}
