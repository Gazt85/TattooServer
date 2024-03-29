﻿using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configuration
{
    public class AppointmentCofiguration : IEntityTypeConfiguration<AppointmentData>
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
                    UserId = new Guid("1497EB69-419F-40D4-BDE3-A40A0FDB99B0"),
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
                UserId = new Guid("BEFB2D78-B315-42E5-BA02-C1183FD60756"),
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
                UserId = new Guid("A5EE6FB2-BCF0-4214-AE92-3AF7E610FA03"),
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
                UserId = new Guid("10AA1197-16F0-4BBA-B5CD-637EBD6D3EFF"),
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
                UserId =  new Guid("76258C5C-F7FD-42ED-B5CB-BFA8DE160963"),
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
                UserId = new Guid("22E1EAA2-BF97-4C83-8AF6-84EB303F8A56"),
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
