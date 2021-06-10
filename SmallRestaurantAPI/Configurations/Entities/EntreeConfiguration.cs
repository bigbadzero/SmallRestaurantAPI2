using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmallRestaurantAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallRestaurantAPI.Configurations.Entities
{
    public class EntreeConfiguration: IEntityTypeConfiguration<Entree>
    {
        public void Configure(EntityTypeBuilder<Entree> builder)
        {
            builder.HasData(
                new Entree
                {
                    ID = 1,
                    Name = "Cheese Burger",
                    CategoryID = 1,
                },
                new Entree
                {
                    ID = 2,
                    Name = "3 Piece Chicken Finger",
                    CategoryID = 2,
                },
                new Entree
                {
                    ID = 3,
                    Name = "Pepperoni Pizza",
                    CategoryID = 3,
                }
                );
        }
    }
}
