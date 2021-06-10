using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmallRestaurantAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Configurations.Entities
{
    public class SideConfiguration : IEntityTypeConfiguration<Side>
    {
        public void Configure(EntityTypeBuilder<Side> builder)
        {
            builder.HasData(
                new Side
                {
                    ID = 1,
                    Name = "French Fries",

                },
                new Side
                {
                    ID = 2,
                    Name = "Onion Rings",

                }
                );
        }
    }
}
