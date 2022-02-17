using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Entities.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData
                (
            new Product
            {
                Id = new Guid("f749e0cd-1917-401e-a8da-27e2d88da463"),
                Name = "Remera Kill em' All",
                Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                ImageSource = @"img\merch\metallica.png",
                Category = "Merchandising",
                Price = 500
            },

            new Product
            {
                Id = new Guid("52c007e5-4b58-4e61-91fc-b8b95a430bb9"),
                Name = "Remera Ride The Lighting",
                Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                ImageSource = @"img\merch\RideTheLighting.png",
                Category = "Merchandising",
                Price = 600
            },
            new Product
            {
                Id = new Guid("59cc79df-7ea9-4a4a-ab2b-5e598014152b"),
                Name = "Remera Vintage",
                Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                ImageSource = @"img\merch\Vintage.png",
                Category = "Merchandising",
                Price = 750,
            },

            new Product
            {
                Id = new Guid("85899333-5F20-4E30-9DA7-7DC66C3DD198"),
                Name = "Taza Personalizada",
                Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                ImageSource = @"img\merch\Mug.png",
                Category = "Merchandising",
                Price = 500
            }
                );
        }
    }
}
