using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configuration
{
    public class VideoConfiguration : IEntityTypeConfiguration<Video>
    {
        public void Configure(EntityTypeBuilder<Video> builder)
        {
            builder.HasData
                (
                new Video
                {
                    Id= new Guid("6C3779FA-7CB5-4A17-9733-65EA91E0D138"),
                    Title = "Tyranny",
                    Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                    Date = new DateTime(2020, 12, 12),
                    Link = "https://www.youtube.com/watch?v=0HU1rMDGyB8&t=202s"
                },

            new Video
            {
                Id= new Guid("B809488C-0037-4ADC-9D2F-89DCAA65758B"),
                Title = "Nerium",
                Description = "This is a wider card with supporting text below as a natural lead-in to additional content",
                Date = new DateTime(2020, 12, 12),
                ImageSource = @"img\Eka logo.jpeg",
                Link = "https://www.youtube.com/watch?v=BL2NHqc74sQ&ab_channel=NERIUMOFFICIALNERIUMOFFICIAL"

            },

            new Video
            {
                Id = new Guid("0ADF51BC-CEAC-49B8-96E8-92E285F59614"),
                Title = "Whiskey Blues",
                Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                Date = new DateTime(2020, 12, 12),
                ImageSource = @"img\tattoo\leon.jpeg",
                Link = "https://www.youtube.com/watch?v=f5jGX9A6ErA&ab_channel=JAZZ%26BLUESJAZZ%26BLUES"
            },

            new Video
            {
                Id = new Guid("B9A9681E-1CE4-498B-AE59-1B76DD8028CF"),
                Title = "Bra vs Ger",
                Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                Date = new DateTime(2020, 12, 12),
                ImageSource = @"img\Eka logo.jpeg",
                Link = "https://www.youtube.com/watch?v=m3HZKHTLHDU&ab_channel=RptimaoTV2RptimaoTV2"
            },

            new Video
            {
                Id = new Guid("39611369-A99E-4670-B9FD-6D82D2ED97C4"),
                Title = "The Witcher",
                Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                Date = new DateTime(2020, 12, 12),
                Link = "https://www.youtube.com/watch?v=PyYlB_MVuLM"

            },
             new Video
             {
                 Id = new Guid("2C08208A-765B-4B49-B74C-C4B38FD6F655"),
                 Title = "Breaking Bad",
                 Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                 Date = new DateTime(2020, 12, 12),
                 Link = "https://www.youtube.com/watch?v=NQ1n5KHTAvo&ab_channel=Shane"
             }
                );
        }
    }
}
