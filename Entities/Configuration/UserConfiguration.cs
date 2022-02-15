using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData
                (
                new User
                {
                    Id = new Guid("8DA804EB-2F2C-4411-AF61-BF0B4EFA4E62"),
                    IsAdmin = true,
                    Email = "ekaEpitafio@gmail.com",
                    Password = "eka666"
                },
                 new User
                 {
                     Id = new Guid("FB4FD82F-FBAD-4B86-9492-D940E7084248"),
                     IsAdmin = true,
                     Email = "gastmartinez85@gmail.com",
                     Password = "gaston666"
                 },
                 new User
                 {
                     Id = new Guid("BEFB2D78-B315-42E5-BA02-C1183FD60756"),
                     IsAdmin = false,
                     Email = "brian@noemail.com",
                     Password = "elBrian"
                 },
                  new User
                  {
                      Id = new Guid("A5EE6FB2-BCF0-4214-AE92-3AF7E610FA03"),
                      IsAdmin = false,
                      Email = "sofia@noemail.com",
                      Password = "test111"
                  },
                   new User
                   {
                       Id = new Guid("10AA1197-16F0-4BBA-B5CD-637EBD6D3EFF"),
                       IsAdmin = false,
                       Email = "lucas@noemail.com",
                       Password = "test111"
                   },
                    new User
                    {
                        Id = new Guid("76258C5C-F7FD-42ED-B5CB-BFA8DE160963"),
                        IsAdmin = false,
                        Email = "diego@noemail.com",
                        Password = "test111"
                    },
                     new User
                     {
                         Id = new Guid("1497EB69-419F-40D4-BDE3-A40A0FDB99B0"),
                         IsAdmin = false,
                         Email = "juan@noemail.com",
                         Password = "test111"
                     },
                      new User
                      {
                          Id = new Guid("22E1EAA2-BF97-4C83-8AF6-84EB303F8A56"),
                          IsAdmin = false,
                          Email = "nati@noemail.com",
                          Password = "test111"
                      }
                );
        }
    }
}
