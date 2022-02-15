using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configuration
{
    public class BlogItemConfiguration : IEntityTypeConfiguration<BlogItem>
    {
        public void Configure(EntityTypeBuilder<BlogItem> builder)
        {
            builder.HasData
               (
                new BlogItem
                {
                    Id = new Guid("be91104c-514a-4392-979d-8b6960b4a868"),
                    BlogPostId = new Guid("26b7976a-7f88-402d-a96c-d15ca965c012"),
                    Title = "Cuidados del Tattoo",
                    Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
            "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat." +
            " Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. " +
            "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    Date = new DateTime(2020, 12, 5),                    
                },
                new BlogItem
                {
                    Id = new Guid("84e9d9ee-0999-4dd7-8292-87c608a7d418"),
                    BlogPostId = new Guid("b761b9f5-c046-405a-ab0c-ae4352731991"),
                    Title = "Cuidados del Piercing",
                    Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
            "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat." +
            " Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. " +
            "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    Date = new DateTime(2020, 12, 10)
                },
                 new BlogItem
                 {
                     Id = new Guid("7431fb9d-cf01-4f68-8f55-e91f8582ac39"),
                     BlogPostId = new Guid("cca45a43-e80d-46c8-9e34-a4daeffd460f"),
                     Title = "Sorteos",
                     Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
            "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat." +
            " Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. " +
            "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                     Date = new DateTime(2021, 11, 10),
                 }
                );
        }
    }
}
