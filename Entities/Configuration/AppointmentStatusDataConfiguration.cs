using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Entities.Configuration 
{
    public class AppointmentStatusDataConfiguration : IEntityTypeConfiguration<AppointmentStatusData>
    {
        public void Configure(EntityTypeBuilder<AppointmentStatusData> builder)
        {
            builder.HasData
               (
                 new AppointmentStatusData
                 {
                     Id = 1,
                     Name = "Tentativo",
                     Color = "#ea7a57"
                 },

                new AppointmentStatusData
                {
                    Id = 2,
                    Name = "Confirmado",
                    Color = "#7fa900"
                }
               );
        }
    }
}
