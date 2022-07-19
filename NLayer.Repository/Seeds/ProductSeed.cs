using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
            new Product
            {
                Id = 1,
                CategoryId = 1,
                Name = "kalem 1",
                Price = 100,
                Stock = 20,
                CreatedDate = DateTime.Now
            },
            new Product
            {
                Id = 2,
                CategoryId = 2,
                Name = "kitap 2",
                Price = 10,
                Stock = 500,
                CreatedDate = DateTime.Now
            },

            new Product
            {
                Id = 3,
                CategoryId = 1,
                Name = "kalem 3",
                Price = 50,
                Stock = 80,
                CreatedDate = DateTime.Now
            });
        }
    }
}
