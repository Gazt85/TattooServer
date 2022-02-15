using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

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
                    Id = new Guid("FF645D53-55A0-4340-AB6F-CFFE1B7D29D9"),
                    IsAdmin = true,
                    Email = "ekaEpitafio@gmail.com",
                    Password = "eka666"
                },
                 new User
                 {
                     Id = new Guid("00AC69D0-61CB-4C77-B6D4-5119633E0CBA"),
                     IsAdmin = true,
                     Email = "gastmartinez85@gmail.com",
                     Password = "gaston666"
                 },
                 new User
                 {
                     Id = new Guid("4F3A3D6C-684F-4FAF-8AEF-BA53CBFAFC8D"),
                     IsAdmin = false,
                     Email = "brian@noemail.com",
                     Password = "elBrian"
                 },
                  new User
                  {
                      Id = new Guid("098FA9C5-6E5F-4F9F-8CBA-98AE0C0E6AE9"),
                      IsAdmin = false,
                      Email = "testuser@gmail.com",
                      Password = "test111"
                  },
                   new User
                   {
                       Id = new Guid("644897DC-F357-4F24-9005-8C9248F240BF"),
                       IsAdmin = false,
                       Email = "kimberly@gmail.com",
                       Password = "kim111"
                   },
                    new User
                    {
                        Id = new Guid("D6EF09BB-1B3E-46BD-A7B8-8CCCDB9D1684"),
                        IsAdmin = false,
                        Email = "shrek@gmail.com",
                        Password = "shrek111"
                    },
                     new User
                     {
                         Id = new Guid("6056DECF-403C-4A72-B047-F1A614936B07"),
                         IsAdmin = false,
                         Email = "fionna@gmail.com",
                         Password = "fiona111"
                     },
                      new User
                      {
                          Id = new Guid("471D579C-9B8D-46F9-BEE4-43CAD5B81212"),
                          IsAdmin = false,
                          Email = "maicol@gmail.com",
                          Password = "maicol111"
                      },
                       new User
                       {
                           Id = new Guid("AC21E66D-2AF4-491C-B77D-95780167E06A"),
                           IsAdmin = false,
                           Email = "jenny@gmail.com",
                           Password = "jenny111"
                       }
                ) ;
        }
    }
}
