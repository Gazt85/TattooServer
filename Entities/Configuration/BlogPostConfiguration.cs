using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Entities.Configuration 
{
    public class BlogPostConfiguration : IEntityTypeConfiguration<BlogPost>
    {
        public void Configure(EntityTypeBuilder<BlogPost> builder)
        {
            builder.HasData
              (
                new BlogPost
                {
                    Id = new Guid("26b7976a-7f88-402d-a96c-d15ca965c012"),
                    Title = "Cuidados del Tattoo",
                    Description = "En este post hablamos sobre los cuidados que debes tener con tu tatuaje.",
                    Date = new DateTime(2020, 12, 5),
                    Pinned = true
                },
                 new BlogPost
                 {
                     Id = new Guid("b761b9f5-c046-405a-ab0c-ae4352731991"),
                     Title = "Cuidados del Piercing",
                     Description = "En este post hablamos sobre los cuidados que debes tener con tu piercing.",
                     Date = new DateTime(2020, 12, 10),
                     Pinned = true
                 },
                  new BlogPost
                  {
                      Id = new Guid("cca45a43-e80d-46c8-9e34-a4daeffd460f"),
                      Title = "Sorteos",
                      Description = "Enterate como participar de nuestros sorteos mensuales",
                      Date = new DateTime(2021, 11, 10),
                      Pinned = false
                  }
                );
        }
    }
}
