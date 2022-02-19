using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

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
                            Id = new Guid("D0A09D0F-DA6E-4C4E-BFB1-F4D81BF39F72"),
                            IsAdmin = false,
                            Email = "default@noemail.com",
                            Password = "default111",
                            FirstName = "Usuario",
                            LastName = "Default",                            
                        }
                );
        }
    }
}
