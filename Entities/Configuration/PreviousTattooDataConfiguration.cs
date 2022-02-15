using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configuration
{
    public class PreviousTattooDataConfiguration : IEntityTypeConfiguration<PreviousTattooData>
    {
        public void Configure(EntityTypeBuilder<PreviousTattooData> builder)
        {
            builder.HasData
               (
                  new PreviousTattooData
                  {
                      Id = 1,
                      Option = "NO"
                  },

                  new PreviousTattooData
                  {
                      Id = 2,
                      Option = "SI"
                  }
                );
        }
    }
}
