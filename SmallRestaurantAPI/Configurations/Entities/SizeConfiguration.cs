using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmallRestaurantAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Configurations.Entities
{
    public class SizeConfiguration : IEntityTypeConfiguration<Size>
    {
        public void Configure(EntityTypeBuilder<Size> builder)
        {
            builder.HasData(
                new Size
                {
                    ID = 1,
                    Name = 'S'
                },
                new Size
                {
                    ID = 2,
                    Name = 'M'
                },
                new Size
                {
                    ID = 3,
                    Name = 'L'
                }
                );
        }
    }
}
