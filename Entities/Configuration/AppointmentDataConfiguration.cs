using System;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configuration
{
    public class AppointmentDataConfiguration : IEntityTypeConfiguration<AppointmentData>
    {
        public void Configure(EntityTypeBuilder<AppointmentData> builder)
        {
            builder.HasData
               (
                new AppointmentData
                {
                    Id = new Guid("e22c5d2c-e98a-44b2-91e0-1a1397317901"),
                    FirstName = "Juan",
                    LastName = "Perez",
                    Phone = "098654123",                    
                    UserId = new Guid("4F3A3D6C-684F-4FAF-8AEF-BA53CBFAFC8D"),
                    TattooDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
            "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat." +
            " Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. " +
            "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    HasPreviousTattoos = false,
                    StartDateTime = new DateTime(2021, 12, 5, 9, 30, 0),
                    EndDatetime = new DateTime(2021, 12, 5, 10, 30, 0),
                    Photo = @"img\tattoo\IronMaiden.jpeg",
                    StatusId = 0,
                    TattooHeight = 10,
                    TattooWidth = 15
                },
            new AppointmentData
            {
                Id = new Guid("e66c2ad3-2be8-43bb-95f8-edce81b46f1a"),
                FirstName = "Brian",
                LastName = "Rodriguez",
                UserId = new Guid("098FA9C5-6E5F-4F9F-8CBA-98AE0C0E6AE9"),
                Phone = "098456123",
                TattooDescription = "Lorem ipsum it ments saab dolore ullamco laboris nisi ut",
                HasPreviousTattoos = true,
                StartDateTime = new DateTime(2021, 12, 8, 16, 00, 0),
                EndDatetime = new DateTime(2021, 12, 8, 19, 30, 0),
                StatusId = 1,
                TattooHeight = 30,
                TattooWidth = 20
            },
            new AppointmentData
            {
                Id = new Guid("3bf3b353-6c41-478f-b5e9-73ba70979942"),
                FirstName = "Sofia",
                LastName = "Sanchez",
                Phone = "098753159",
                UserId = new Guid("644897DC-F357-4F24-9005-8C9248F240BF"),
                TattooDescription = "Lorem ipsum it ments saab dolore ullamco laboris nisi ut",
                HasPreviousTattoos = false,
                StartDateTime = new DateTime(2021, 12, 17, 15, 30, 0),
                EndDatetime = new DateTime(2021, 12, 17, 17, 30, 0),
                Photo = @"img\tattoo\IronMaiden.jpeg",
                StatusId = 1,
                TattooHeight = 10,
                TattooWidth = 15
            },
            new AppointmentData
            {
                Id = new Guid("9d797c0e-3280-4434-8a55-8055221a279c"),
                FirstName = "Lucas",
                LastName = "Padilla",
                Phone = "098654442",
                UserId = new Guid("D6EF09BB-1B3E-46BD-A7B8-8CCCDB9D1684"),
                TattooDescription = "Lorem ipsum it ments saab dolore ullamco laboris nisi ut",
                HasPreviousTattoos = true,
                StartDateTime = new DateTime(2021, 12, 7, 15, 30, 0),
                EndDatetime = new DateTime(2021, 12, 7, 16, 30, 0),
                StatusId = 0,
                TattooHeight = 10,
                TattooWidth = 15
            },
            new AppointmentData
            {
                Id = new Guid("a5008a5a-1d56-4b65-80fd-d8b5da9772b5"),
                FirstName = "Diego",
                LastName = "Lopez",
                Phone = "098652523",
                UserId = new Guid("6056DECF-403C-4A72-B047-F1A614936B07"),
                TattooDescription = "Lorem ipsum it ments",
                StartDateTime = new DateTime(2021, 12, 7, 14, 30, 0),
                EndDatetime = new DateTime(2021, 12, 7, 15, 30, 0),
                StatusId = 0,
                TattooHeight = 10,
                TattooWidth = 15
            },
            new AppointmentData
            {
                Id = new Guid("c083623f-ec5b-4d28-8bcb-a4b2f1cf053b"),
                FirstName = "Natalia",
                LastName = "Sosa",
                Phone = "0987549823",
                UserId = new Guid("471D579C-9B8D-46F9-BEE4-43CAD5B81212"),
                TattooDescription = "Lorem ipsum it ments",
                StartDateTime = new DateTime(2021, 12, 9, 12, 30, 0),
                EndDatetime = new DateTime(2021, 12, 9, 15, 30, 0),
                StatusId = 1,
                TattooHeight = 10,
                TattooWidth = 15
            }
                );
        }
    }
}
