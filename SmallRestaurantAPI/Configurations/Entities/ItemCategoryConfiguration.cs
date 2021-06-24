using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmallRestaurantAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Configurations.Entities
{
    public class ItemCategoryConfiguration : IEntityTypeConfiguration<ItemCategory>
    {
        public void Configure(EntityTypeBuilder<ItemCategory> builder)
        {
            builder.HasData(
                new ItemCategory
                {
                    ID = 1,
                    ItemID = 1,
                    CategoryID = 1
                },
                new ItemCategory
                {
                    ID = 2,
                    ItemID = 1,
                    CategoryID = 4
                },
                new ItemCategory
                {
                    ID = 3,
                    ItemID = 2,
                    CategoryID = 1
                }
                );
        }
    }
}
