using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmallRestaurantAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Configurations.Entities
{
    public class DrinkConfiguration : IEntityTypeConfiguration<Drink>
    {
        public void Configure(EntityTypeBuilder<Drink> builder)
        {
            builder.HasData(
                new Drink
                {
                    ID = 1,
                    Name = "Sweat Tea",
                },
                new Drink
                {
                    ID = 2,
                    Name = "Coke"
                },
                new Drink
                {
                    ID = 3,
                    Name = "Dr.Pepper"
                }
                );
        }
    }
}
