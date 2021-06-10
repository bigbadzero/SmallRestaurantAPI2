using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmallRestaurantAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Configurations.Entities
{
    public class ComboConfiguration : IEntityTypeConfiguration<Combo>
    {
        public void Configure(EntityTypeBuilder<Combo> builder)
        {
            builder.HasData(
                new Combo
                {
                    ID = 1,
                    ComboNumber = 1,
                    Name = "Cheese Burger Combo",
                    EntreeID = 1
                },
                new Combo
                {
                    ID = 2,
                    ComboNumber = 2,
                    Name = "3 Piece Chicken Finger Combo",
                    EntreeID = 2
                }
                );
        }
    }
}
