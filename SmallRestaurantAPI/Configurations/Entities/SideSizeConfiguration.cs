using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmallRestaurantAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Configurations.Entities
{
    public class SideSizeConfiguration : IEntityTypeConfiguration<SideSize>
    {
        public void Configure(EntityTypeBuilder<SideSize> builder)
        {
            builder.HasData(
                new SideSize
                {
                    ID = 1,
                    SideID = 1,
                    SizeID = 1,
                },
                new SideSize
                {
                    ID = 2,
                    SideID = 1,
                    SizeID = 2,
                },
                new SideSize
                {
                    ID = 3,
                    SideID = 1,
                    SizeID = 3,
                },
                new SideSize
                {
                    ID = 4,
                    SideID = 2,
                    SizeID = 1,
                },
                new SideSize
                {
                    ID = 4,
                    SideID = 2,
                    SizeID = 2,
                },
                new SideSize
                {
                    ID = 4, 
                    SideID = 2,
                    SizeID = 3,
                }
                );
        }
    }
}
