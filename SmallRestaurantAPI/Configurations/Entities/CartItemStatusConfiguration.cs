using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmallRestaurantAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Configurations.Entities
{
    public class CartItemStatusConfiguration : IEntityTypeConfiguration<CartItemStatus>
    {
        public void Configure(EntityTypeBuilder<CartItemStatus> builder)
        {
            builder.HasData(
                new CartItemStatus
                {
                    ID = 1,
                    Name = "Ordering"
                },
                new CartItemStatus
                {
                    ID = 2,
                    Name = "Order Processing"
                },
                new CartItemStatus
                {
                    ID = 3,
                    Name = "Order Ready"
                },
                new CartItemStatus
                {
                    ID = 4,
                    Name = "Order Complete"
                }
                );
        }
    }
}
