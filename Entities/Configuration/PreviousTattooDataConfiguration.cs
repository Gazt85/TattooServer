using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

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
                      Id = 0,
                      Option = "NO"
                  },

                  new PreviousTattooData
                  {
                      Id = 1,
                      Option = "SI"
                  }
                );
        }

    }
}
