using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmallRestaurantAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Configurations.Entities
{
    public class ComboSideItemConfiguration : IEntityTypeConfiguration<ComboSideItem>
    {
        public void Configure(EntityTypeBuilder<ComboSideItem> builder)
        {
            builder.HasData(
                new ComboSideItem
                {
                    ID = 1,
                    TypeID = 2,
                    ComboID = 1,
                    ItemID = 3
                }
                );
        }
    }
}
