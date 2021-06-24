using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmallRestaurantAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Configurations.Entities
{
    public class ItemSizeConfiguration : IEntityTypeConfiguration<ItemSize>
    {
        public void Configure(EntityTypeBuilder<ItemSize> builder)
        {
            builder.HasData(
                new ItemSize
                {
                    ID = 1,
                    ItemID = 1,
                    SizeID = 2
                },
                new ItemSize
                {
                    ID = 2,
                    ItemID = 1,
                    SizeID = 3
                },
                new ItemSize
                {
                    ID = 3,
                    ItemID = 2,
                    SizeID = 2
                },
                new ItemSize
                {
                    ID = 4,
                    ItemID = 2,
                    SizeID = 3
                }
                );
        }
    }
}
