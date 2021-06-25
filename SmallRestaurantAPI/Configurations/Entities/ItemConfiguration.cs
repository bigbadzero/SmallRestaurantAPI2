using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmallRestaurantAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Configurations.Entities
{
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasData(
                new Item
                {
                    ID = 1,
                    Name = "CheeseBurger",
                    TypeID = 1
                },
                new Item
                {
                    ID = 2,
                    Name = "Hamburger",
                    TypeID = 1
                },
                new Item
                {
                    ID = 3,
                    Name = "Fries",
                    TypeID = 2
                },
                new Item
                {
                    ID = 4,
                    Name = "Coke",
                    TypeID = 3
                }
                );
        }
    }
}
