using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmallRestaurantAPI.Data;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SmallRestaurantAPI.Configurations.Entities
{
    public class TypeConfiguration : IEntityTypeConfiguration<Data.Type>
    {
        public void Configure(EntityTypeBuilder<Data.Type> builder)
        {
            builder.HasData(
                new Data.Type
                {
                    ID = 1,
                    Name = "Entree"
                },
                new Data.Type
                {
                    ID = 2,
                    Name = "Side"
                },
                new Data.Type
                {
                    ID = 3,
                    Name = "Drink"
                },
                new Data.Type
                {
                    ID = 4,
                    Name = "Combo"
                }
                );
        }
    }
}
