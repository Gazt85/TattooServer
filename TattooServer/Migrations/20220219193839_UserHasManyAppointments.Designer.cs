﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace TattooServer.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20220219193839_UserHasManyAppointments")]
    partial class UserHasManyAppointments
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Models.AppointmentData", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AppointmenId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EndDatetime")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<bool>("HasPreviousTattoos")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<string>("TattooDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<double>("TattooHeight")
                        .HasColumnType("float");

                    b.Property<double>("TattooWidth")
                        .HasColumnType("float");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Appointments");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e22c5d2c-e98a-44b2-91e0-1a1397317901"),
                            EndDatetime = new DateTime(2021, 12, 5, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Juan",
                            HasPreviousTattoos = false,
                            LastName = "Perez",
                            Phone = "098654123",
                            Photo = "img\\tattoo\\IronMaiden.jpeg",
                            StartDateTime = new DateTime(2021, 12, 5, 9, 30, 0, 0, DateTimeKind.Unspecified),
                            StatusId = 0,
                            TattooDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                            TattooHeight = 10.0,
                            TattooWidth = 15.0,
                            UserId = new Guid("1497eb69-419f-40d4-bde3-a40a0fdb99b0")
                        },
                        new
                        {
                            Id = new Guid("e66c2ad3-2be8-43bb-95f8-edce81b46f1a"),
                            EndDatetime = new DateTime(2021, 12, 8, 19, 30, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Brian",
                            HasPreviousTattoos = true,
                            LastName = "Rodriguez",
                            Phone = "098456123",
                            StartDateTime = new DateTime(2021, 12, 8, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            StatusId = 1,
                            TattooDescription = "Lorem ipsum it ments saab dolore ullamco laboris nisi ut",
                            TattooHeight = 30.0,
                            TattooWidth = 20.0,
                            UserId = new Guid("befb2d78-b315-42e5-ba02-c1183fd60756")
                        },
                        new
                        {
                            Id = new Guid("3bf3b353-6c41-478f-b5e9-73ba70979942"),
                            EndDatetime = new DateTime(2021, 12, 17, 17, 30, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Sofia",
                            HasPreviousTattoos = false,
                            LastName = "Sanchez",
                            Phone = "098753159",
                            Photo = "img\\tattoo\\IronMaiden.jpeg",
                            StartDateTime = new DateTime(2021, 12, 17, 15, 30, 0, 0, DateTimeKind.Unspecified),
                            StatusId = 1,
                            TattooDescription = "Lorem ipsum it ments saab dolore ullamco laboris nisi ut",
                            TattooHeight = 10.0,
                            TattooWidth = 15.0,
                            UserId = new Guid("a5ee6fb2-bcf0-4214-ae92-3af7e610fa03")
                        },
                        new
                        {
                            Id = new Guid("9d797c0e-3280-4434-8a55-8055221a279c"),
                            EndDatetime = new DateTime(2021, 12, 7, 16, 30, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Lucas",
                            HasPreviousTattoos = true,
                            LastName = "Padilla",
                            Phone = "098654442",
                            StartDateTime = new DateTime(2021, 12, 7, 15, 30, 0, 0, DateTimeKind.Unspecified),
                            StatusId = 0,
                            TattooDescription = "Lorem ipsum it ments saab dolore ullamco laboris nisi ut",
                            TattooHeight = 10.0,
                            TattooWidth = 15.0,
                            UserId = new Guid("10aa1197-16f0-4bba-b5cd-637ebd6d3eff")
                        },
                        new
                        {
                            Id = new Guid("a5008a5a-1d56-4b65-80fd-d8b5da9772b5"),
                            EndDatetime = new DateTime(2021, 12, 7, 15, 30, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Diego",
                            HasPreviousTattoos = false,
                            LastName = "Lopez",
                            Phone = "098652523",
                            StartDateTime = new DateTime(2021, 12, 7, 14, 30, 0, 0, DateTimeKind.Unspecified),
                            StatusId = 0,
                            TattooDescription = "Lorem ipsum it ments",
                            TattooHeight = 10.0,
                            TattooWidth = 15.0,
                            UserId = new Guid("76258c5c-f7fd-42ed-b5cb-bfa8de160963")
                        },
                        new
                        {
                            Id = new Guid("c083623f-ec5b-4d28-8bcb-a4b2f1cf053b"),
                            EndDatetime = new DateTime(2021, 12, 9, 15, 30, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Natalia",
                            HasPreviousTattoos = false,
                            LastName = "Sosa",
                            Phone = "0987549823",
                            StartDateTime = new DateTime(2021, 12, 9, 12, 30, 0, 0, DateTimeKind.Unspecified),
                            StatusId = 1,
                            TattooDescription = "Lorem ipsum it ments",
                            TattooHeight = 10.0,
                            TattooWidth = 15.0,
                            UserId = new Guid("22e1eaa2-bf97-4c83-8af6-84eb303f8a56")
                        });
                });

            modelBuilder.Entity("Entities.Models.AppointmentStatusData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppointmentStatus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "#ea7a57",
                            Name = "Tentativo"
                        },
                        new
                        {
                            Id = 2,
                            Color = "#7fa900",
                            Name = "Confirmado"
                        });
                });

            modelBuilder.Entity("Entities.Models.BlogItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("BlogId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BlogPostId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.HasIndex("BlogPostId");

                    b.ToTable("BlogItems");

                    b.HasData(
                        new
                        {
                            Id = new Guid("be91104c-514a-4392-979d-8b6960b4a868"),
                            BlogPostId = new Guid("26b7976a-7f88-402d-a96c-d15ca965c012"),
                            Date = new DateTime(2020, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. ",
                            Title = "Cuidados del Tattoo"
                        },
                        new
                        {
                            Id = new Guid("84e9d9ee-0999-4dd7-8292-87c608a7d418"),
                            BlogPostId = new Guid("b761b9f5-c046-405a-ab0c-ae4352731991"),
                            Date = new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. ",
                            Title = "Cuidados del Piercing"
                        },
                        new
                        {
                            Id = new Guid("7431fb9d-cf01-4f68-8f55-e91f8582ac39"),
                            BlogPostId = new Guid("cca45a43-e80d-46c8-9e34-a4daeffd460f"),
                            Date = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. ",
                            Title = "Sorteos"
                        });
                });

            modelBuilder.Entity("Entities.Models.BlogPost", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("BlogPostId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(2000)")
                        .HasMaxLength(2000);

                    b.Property<bool>("Pinned")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("BlogPosts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("26b7976a-7f88-402d-a96c-d15ca965c012"),
                            Date = new DateTime(2020, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "En este post hablamos sobre los cuidados que debes tener con tu tatuaje.",
                            Pinned = true,
                            Title = "Cuidados del Tattoo"
                        },
                        new
                        {
                            Id = new Guid("b761b9f5-c046-405a-ab0c-ae4352731991"),
                            Date = new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "En este post hablamos sobre los cuidados que debes tener con tu piercing.",
                            Pinned = true,
                            Title = "Cuidados del Piercing"
                        },
                        new
                        {
                            Id = new Guid("cca45a43-e80d-46c8-9e34-a4daeffd460f"),
                            Date = new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Enterate como participar de nuestros sorteos mensuales",
                            Pinned = false,
                            Title = "Sorteos"
                        });
                });

            modelBuilder.Entity("Entities.Models.PreviousTattooData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Option")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PreviousTattooData");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Option = "NO"
                        },
                        new
                        {
                            Id = 2,
                            Option = "SI"
                        });
                });

            modelBuilder.Entity("Entities.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("ImageSource")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f749e0cd-1917-401e-a8da-27e2d88da463"),
                            Category = "Merchandising",
                            Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                            ImageSource = "img\\merch\\metallica.png",
                            Name = "Remera Kill em' All",
                            Price = 500m
                        },
                        new
                        {
                            Id = new Guid("52c007e5-4b58-4e61-91fc-b8b95a430bb9"),
                            Category = "Merchandising",
                            Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                            ImageSource = "img\\merch\\RideTheLighting.png",
                            Name = "Remera Ride The Lighting",
                            Price = 600m
                        },
                        new
                        {
                            Id = new Guid("59cc79df-7ea9-4a4a-ab2b-5e598014152b"),
                            Category = "Merchandising",
                            Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                            ImageSource = "img\\merch\\Vintage.png",
                            Name = "Remera Vintage",
                            Price = 750m
                        },
                        new
                        {
                            Id = new Guid("4aa3bac2-ede7-4411-9619-5e1e2fe67338"),
                            Category = "Merchandising",
                            Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                            ImageSource = "img\\merch\\Mug.png",
                            Name = "Taza Personalizada",
                            Price = 500m
                        });
                });

            modelBuilder.Entity("Entities.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8da804eb-2f2c-4411-af61-bf0b4efa4e62"),
                            Email = "ekaEpitafio@gmail.com",
                            IsAdmin = true,
                            Password = "eka666"
                        },
                        new
                        {
                            Id = new Guid("fb4fd82f-fbad-4b86-9492-d940e7084248"),
                            Email = "gastmartinez85@gmail.com",
                            IsAdmin = true,
                            Password = "gaston666"
                        },
                        new
                        {
                            Id = new Guid("befb2d78-b315-42e5-ba02-c1183fd60756"),
                            Email = "brian@noemail.com",
                            IsAdmin = false,
                            Password = "elBrian"
                        },
                        new
                        {
                            Id = new Guid("a5ee6fb2-bcf0-4214-ae92-3af7e610fa03"),
                            Email = "sofia@noemail.com",
                            IsAdmin = false,
                            Password = "test111"
                        },
                        new
                        {
                            Id = new Guid("10aa1197-16f0-4bba-b5cd-637ebd6d3eff"),
                            Email = "lucas@noemail.com",
                            IsAdmin = false,
                            Password = "test111"
                        },
                        new
                        {
                            Id = new Guid("76258c5c-f7fd-42ed-b5cb-bfa8de160963"),
                            Email = "diego@noemail.com",
                            IsAdmin = false,
                            Password = "test111"
                        },
                        new
                        {
                            Id = new Guid("1497eb69-419f-40d4-bde3-a40a0fdb99b0"),
                            Email = "juan@noemail.com",
                            IsAdmin = false,
                            Password = "test111"
                        },
                        new
                        {
                            Id = new Guid("22e1eaa2-bf97-4c83-8af6-84eb303f8a56"),
                            Email = "nati@noemail.com",
                            IsAdmin = false,
                            Password = "test111"
                        });
                });

            modelBuilder.Entity("Entities.Models.Video", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("VideoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("ImageSource")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Videos");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6c3779fa-7cb5-4a17-9733-65ea91e0d138"),
                            Date = new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                            Link = "https://www.youtube.com/watch?v=0HU1rMDGyB8&t=202s",
                            Title = "Tyranny"
                        },
                        new
                        {
                            Id = new Guid("b809488c-0037-4adc-9d2f-89dcaa65758b"),
                            Date = new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a wider card with supporting text below as a natural lead-in to additional content",
                            ImageSource = "img\\Eka logo.jpeg",
                            Link = "https://www.youtube.com/watch?v=BL2NHqc74sQ&ab_channel=NERIUMOFFICIALNERIUMOFFICIAL",
                            Title = "Nerium"
                        },
                        new
                        {
                            Id = new Guid("0adf51bc-ceac-49b8-96e8-92e285f59614"),
                            Date = new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                            ImageSource = "img\\tattoo\\leon.jpeg",
                            Link = "https://www.youtube.com/watch?v=f5jGX9A6ErA&ab_channel=JAZZ%26BLUESJAZZ%26BLUES",
                            Title = "Whiskey Blues"
                        },
                        new
                        {
                            Id = new Guid("b9a9681e-1ce4-498b-ae59-1b76dd8028cf"),
                            Date = new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                            ImageSource = "img\\Eka logo.jpeg",
                            Link = "https://www.youtube.com/watch?v=m3HZKHTLHDU&ab_channel=RptimaoTV2RptimaoTV2",
                            Title = "Bra vs Ger"
                        },
                        new
                        {
                            Id = new Guid("39611369-a99e-4670-b9fd-6d82d2ed97c4"),
                            Date = new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                            Link = "https://www.youtube.com/watch?v=PyYlB_MVuLM",
                            Title = "The Witcher"
                        },
                        new
                        {
                            Id = new Guid("2c08208a-765b-4b49-b74c-c4b38fd6f655"),
                            Date = new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                            Link = "https://www.youtube.com/watch?v=NQ1n5KHTAvo&ab_channel=Shane",
                            Title = "Breaking Bad"
                        });
                });

            modelBuilder.Entity("Entities.Models.Client", b =>
                {
                    b.HasBaseType("Entities.Models.User");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasDiscriminator().HasValue("Client");
                });

            modelBuilder.Entity("Entities.Models.AppointmentData", b =>
                {
                    b.HasOne("Entities.Models.User", "User")
                        .WithMany("Appointments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Models.BlogItem", b =>
                {
                    b.HasOne("Entities.Models.BlogPost", "BlogPost")
                        .WithMany()
                        .HasForeignKey("BlogPostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}