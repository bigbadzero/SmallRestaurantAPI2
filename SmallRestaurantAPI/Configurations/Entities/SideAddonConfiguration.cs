using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmallRestaurantAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Configurations.Entities
{
    public class SideAddonConfiguration : IEntityTypeConfiguration<SideAddon>
    {
        public void Configure(EntityTypeBuilder<SideAddon> builder)
        {
            builder.HasData(
                new SideAddon
                {
                    ID = 1,
                    SideID = 1,
                    IngredientID = 3
                }
                );
        }
    }
}
