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
                },
                new ItemSize
                {
                    ID = 5,
                    ItemID = 3,
                    SizeID = 1
                },
                new ItemSize
                {
                    ID = 6,
                    ItemID = 3,
                    SizeID = 2
                },
                new ItemSize
                {
                    ID = 7,
                    ItemID = 3,
                    SizeID = 3
                },
                new ItemSize
                {
                    ID = 8,
                    ItemID = 4,
                    SizeID = 1
                },
                new ItemSize
                {
                    ID = 9,
                    ItemID = 4,
                    SizeID = 2
                },
                new ItemSize
                {
                    ID = 10,
                    ItemID = 4,
                    SizeID = 3
                }

                );
        }
    }
}
