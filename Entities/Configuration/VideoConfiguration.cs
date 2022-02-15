using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

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
                    Id = new Guid("9BE62997-BFC2-4096-A539-C13665553742"),
                    Title = "Tyranny",
                    Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                    Date = new DateTime(2020, 12, 12),
                    Link = "https://www.youtube.com/watch?v=0HU1rMDGyB8&t=202s"
                },

            new Video
            {
                Id = new Guid("71BB9B15-A5F2-477F-8D7A-970BEFBEEFEA"),
                Title = "Nerium",
                Description = "This is a wider card with supporting text below as a natural lead-in to additional content.This is a wider card with supporting text below as a natural lead-in to additional content",
                Date = new DateTime(2020, 12, 12),
                ImageSource = @"img\Eka logo.jpeg",
                Link = "https://www.youtube.com/watch?v=BL2NHqc74sQ&ab_channel=NERIUMOFFICIALNERIUMOFFICIAL"

            },

            new Video
            {
                Id = new Guid("4F826A82-A14C-44B7-AF18-40C81B021555"),
                Title = "Whiskey Blues",
                Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                Date = new DateTime(2020, 12, 12),
                ImageSource = @"img\tattoo\leon.jpeg",
                Link = "https://www.youtube.com/watch?v=f5jGX9A6ErA&ab_channel=JAZZ%26BLUESJAZZ%26BLUES"
            },

            new Video
            {
                Id = new Guid("BC449310-7897-4D68-B20E-2B659CB97B81"),
                Title = "Bra vs Ger",
                Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                Date = new DateTime(2020, 12, 12),
                ImageSource = @"img\Eka logo.jpeg",
                Link = "https://www.youtube.com/watch?v=m3HZKHTLHDU&ab_channel=RptimaoTV2RptimaoTV2"
            },

            new Video
            {
                Id = new Guid("AB3279B1-2480-44CE-8359-4A5EF7607851"),
                Title = "The Witcher",
                Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                Date = new DateTime(2020, 12, 12),
                Link = "https://www.youtube.com/watch?v=PyYlB_MVuLM"

            },
             new Video
             {
                 Id = new Guid("A38F6A79-0964-4B02-AEEB-0AE441121F12"),
                 Title = "Breaking Bad",
                 Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                 Date = new DateTime(2020, 12, 12),
                 Link = "https://www.youtube.com/watch?v=NQ1n5KHTAvo&ab_channel=Shane"
             }
                );
        }
    }
}
