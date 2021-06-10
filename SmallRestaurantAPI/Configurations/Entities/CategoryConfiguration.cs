using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmallRestaurantAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Configurations.Entities
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    ID = 1,
                    Name = "Burgers"
                },
                new Category
                {
                    ID = 2,
                    Name = "Chicken"
                },
                new Category
                {
                    ID = 3,
                    Name = "Pizza"
                }
                );
        }
    }
}
