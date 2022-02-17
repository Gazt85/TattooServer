using System;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Entities.Configuration
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasData
                (
                new Client
                {
                    Id = new Guid("E3486C1D-9D99-49F2-9838-B87D4BD4D13B"),
                    FirstName = "Brian",
                    LastName = "Rodriguez",
                    Email = "brian@noemail.com",
                    Phone = "098123123",
                },
                new Client
                {
                    Id = new Guid("DCE4CC19-3132-4D6D-97D2-F44B80DB68F5"),
                    FirstName = "Test",
                    LastName = "User",
                    Email = "testuser@gmail.com",
                    Phone = "098123123"
                }
                );
        }
    }
}
