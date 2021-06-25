using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmallRestaurantAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Configurations.Entities
{
    public class ComboDrinkItemConfiguration : IEntityTypeConfiguration<ComboDrinkItem>
    {
        public void Configure(EntityTypeBuilder<ComboDrinkItem> builder)
        {
            builder.HasData(
                new ComboDrinkItem
                {
                    ID = 1,
                    ComboID = 1,
                    ItemID = 4
                }
                );
        }
    }
}
