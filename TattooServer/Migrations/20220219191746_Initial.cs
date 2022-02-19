using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TattooServer.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppointmentStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogPosts",
                columns: table => new
                {
                    BlogPostId = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(maxLength: 250, nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(maxLength: 2000, nullable: false),
                    Pinned = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPosts", x => x.BlogPostId);
                });

            migrationBuilder.CreateTable(
                name: "PreviousTattooData",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Option = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreviousTattooData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: false),
                    Category = table.Column<string>(maxLength: 100, nullable: false),
                    ImageSource = table.Column<string>(maxLength: 1000, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    Email = table.Column<string>(maxLength: 200, nullable: false),
                    Password = table.Column<string>(maxLength: 25, nullable: false),
                    IsAdmin = table.Column<bool>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 100, nullable: true),
                    LastName = table.Column<string>(maxLength: 100, nullable: true),
                    Phone = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Videos",
                columns: table => new
                {
                    VideoId = table.Column<Guid>(nullable: false),
                    Link = table.Column<string>(maxLength: 500, nullable: false),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 150, nullable: false),
                    ImageSource = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Videos", x => x.VideoId);
                });

            migrationBuilder.CreateTable(
                name: "BlogItems",
                columns: table => new
                {
                    BlogId = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(maxLength: 150, nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Summary = table.Column<string>(maxLength: 250, nullable: false),
                    BlogPostId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogItems", x => x.BlogId);
                    table.ForeignKey(
                        name: "FK_BlogItems_BlogPosts_BlogPostId",
                        column: x => x.BlogPostId,
                        principalTable: "BlogPosts",
                        principalColumn: "BlogPostId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    AppointmenId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 100, nullable: false),
                    LastName = table.Column<string>(maxLength: 100, nullable: false),
                    Phone = table.Column<string>(maxLength: 100, nullable: false),
                    TattooDescription = table.Column<string>(maxLength: 500, nullable: false),
                    HasPreviousTattoos = table.Column<bool>(nullable: false),
                    TattooHeight = table.Column<double>(nullable: false),
                    TattooWidth = table.Column<double>(nullable: false),
                    StartDateTime = table.Column<DateTime>(nullable: false),
                    EndDatetime = table.Column<DateTime>(nullable: false),
                    Photo = table.Column<string>(nullable: true),
                    StatusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.AppointmenId);
                    table.ForeignKey(
                        name: "FK_Appointments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AppointmentStatus",
                columns: new[] { "Id", "Color", "Name" },
                values: new object[,]
                {
                    { 1, "#ea7a57", "Tentativo" },
                    { 2, "#7fa900", "Confirmado" }
                });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "BlogPostId", "Date", "Description", "Pinned", "Title" },
                values: new object[,]
                {
                    { new Guid("26b7976a-7f88-402d-a96c-d15ca965c012"), new DateTime(2020, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "En este post hablamos sobre los cuidados que debes tener con tu tatuaje.", true, "Cuidados del Tattoo" },
                    { new Guid("b761b9f5-c046-405a-ab0c-ae4352731991"), new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "En este post hablamos sobre los cuidados que debes tener con tu piercing.", true, "Cuidados del Piercing" },
                    { new Guid("cca45a43-e80d-46c8-9e34-a4daeffd460f"), new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enterate como participar de nuestros sorteos mensuales", false, "Sorteos" }
                });

            migrationBuilder.InsertData(
                table: "PreviousTattooData",
                columns: new[] { "Id", "Option" },
                values: new object[,]
                {
                    { 1, "NO" },
                    { 2, "SI" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Category", "Description", "ImageSource", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("f749e0cd-1917-401e-a8da-27e2d88da463"), "Merchandising", "This is a wider card with supporting text below as a natural lead-in to additional content.", "img\\merch\\metallica.png", "Remera Kill em' All", 500m },
                    { new Guid("52c007e5-4b58-4e61-91fc-b8b95a430bb9"), "Merchandising", "This is a wider card with supporting text below as a natural lead-in to additional content.", "img\\merch\\RideTheLighting.png", "Remera Ride The Lighting", 600m },
                    { new Guid("59cc79df-7ea9-4a4a-ab2b-5e598014152b"), "Merchandising", "This is a wider card with supporting text below as a natural lead-in to additional content.", "img\\merch\\Vintage.png", "Remera Vintage", 750m },
                    { new Guid("4aa3bac2-ede7-4411-9619-5e1e2fe67338"), "Merchandising", "This is a wider card with supporting text below as a natural lead-in to additional content.", "img\\merch\\Mug.png", "Taza Personalizada", 500m }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Discriminator", "Email", "IsAdmin", "Password" },
                values: new object[,]
                {
                    { new Guid("22e1eaa2-bf97-4c83-8af6-84eb303f8a56"), "User", "nati@noemail.com", false, "test111" },
                    { new Guid("1497eb69-419f-40d4-bde3-a40a0fdb99b0"), "User", "juan@noemail.com", false, "test111" },
                    { new Guid("76258c5c-f7fd-42ed-b5cb-bfa8de160963"), "User", "diego@noemail.com", false, "test111" },
                    { new Guid("10aa1197-16f0-4bba-b5cd-637ebd6d3eff"), "User", "lucas@noemail.com", false, "test111" },
                    { new Guid("fb4fd82f-fbad-4b86-9492-d940e7084248"), "User", "gastmartinez85@gmail.com", true, "gaston666" },
                    { new Guid("befb2d78-b315-42e5-ba02-c1183fd60756"), "User", "brian@noemail.com", false, "elBrian" },
                    { new Guid("8da804eb-2f2c-4411-af61-bf0b4efa4e62"), "User", "ekaEpitafio@gmail.com", true, "eka666" },
                    { new Guid("a5ee6fb2-bcf0-4214-ae92-3af7e610fa03"), "User", "sofia@noemail.com", false, "test111" }
                });

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "VideoId", "Date", "Description", "ImageSource", "Link", "Title" },
                values: new object[,]
                {
                    { new Guid("39611369-a99e-4670-b9fd-6d82d2ed97c4"), new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is a wider card with supporting text below as a natural lead-in to additional content.", null, "https://www.youtube.com/watch?v=PyYlB_MVuLM", "The Witcher" },
                    { new Guid("6c3779fa-7cb5-4a17-9733-65ea91e0d138"), new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is a wider card with supporting text below as a natural lead-in to additional content.", null, "https://www.youtube.com/watch?v=0HU1rMDGyB8&t=202s", "Tyranny" },
                    { new Guid("b809488c-0037-4adc-9d2f-89dcaa65758b"), new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is a wider card with supporting text below as a natural lead-in to additional content.", "img\\Eka logo.jpeg", "https://www.youtube.com/watch?v=BL2NHqc74sQ&ab_channel=NERIUMOFFICIALNERIUMOFFICIAL", "Nerium" },
                    { new Guid("0adf51bc-ceac-49b8-96e8-92e285f59614"), new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is a wider card with supporting text below as a natural lead-in to additional content.", "img\\tattoo\\leon.jpeg", "https://www.youtube.com/watch?v=f5jGX9A6ErA&ab_channel=JAZZ%26BLUESJAZZ%26BLUES", "Whiskey Blues" },
                    { new Guid("b9a9681e-1ce4-498b-ae59-1b76dd8028cf"), new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is a wider card with supporting text below as a natural lead-in to additional content.", "img\\Eka logo.jpeg", "https://www.youtube.com/watch?v=m3HZKHTLHDU&ab_channel=RptimaoTV2RptimaoTV2", "Bra vs Ger" },
                    { new Guid("2c08208a-765b-4b49-b74c-c4b38fd6f655"), new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is a wider card with supporting text below as a natural lead-in to additional content.", null, "https://www.youtube.com/watch?v=NQ1n5KHTAvo&ab_channel=Shane", "Breaking Bad" }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmenId", "EndDatetime", "FirstName", "HasPreviousTattoos", "LastName", "Phone", "Photo", "StartDateTime", "StatusId", "TattooDescription", "TattooHeight", "TattooWidth", "UserId" },
                values: new object[,]
                {
                    { new Guid("e66c2ad3-2be8-43bb-95f8-edce81b46f1a"), new DateTime(2021, 12, 8, 19, 30, 0, 0, DateTimeKind.Unspecified), "Brian", true, "Rodriguez", "098456123", null, new DateTime(2021, 12, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lorem ipsum it ments saab dolore ullamco laboris nisi ut", 30.0, 20.0, new Guid("befb2d78-b315-42e5-ba02-c1183fd60756") },
                    { new Guid("3bf3b353-6c41-478f-b5e9-73ba70979942"), new DateTime(2021, 12, 17, 17, 30, 0, 0, DateTimeKind.Unspecified), "Sofia", false, "Sanchez", "098753159", "img\\tattoo\\IronMaiden.jpeg", new DateTime(2021, 12, 17, 15, 30, 0, 0, DateTimeKind.Unspecified), 1, "Lorem ipsum it ments saab dolore ullamco laboris nisi ut", 10.0, 15.0, new Guid("a5ee6fb2-bcf0-4214-ae92-3af7e610fa03") },
                    { new Guid("9d797c0e-3280-4434-8a55-8055221a279c"), new DateTime(2021, 12, 7, 16, 30, 0, 0, DateTimeKind.Unspecified), "Lucas", true, "Padilla", "098654442", null, new DateTime(2021, 12, 7, 15, 30, 0, 0, DateTimeKind.Unspecified), 0, "Lorem ipsum it ments saab dolore ullamco laboris nisi ut", 10.0, 15.0, new Guid("10aa1197-16f0-4bba-b5cd-637ebd6d3eff") },
                    { new Guid("a5008a5a-1d56-4b65-80fd-d8b5da9772b5"), new DateTime(2021, 12, 7, 15, 30, 0, 0, DateTimeKind.Unspecified), "Diego", false, "Lopez", "098652523", null, new DateTime(2021, 12, 7, 14, 30, 0, 0, DateTimeKind.Unspecified), 0, "Lorem ipsum it ments", 10.0, 15.0, new Guid("76258c5c-f7fd-42ed-b5cb-bfa8de160963") },
                    { new Guid("e22c5d2c-e98a-44b2-91e0-1a1397317901"), new DateTime(2021, 12, 5, 10, 30, 0, 0, DateTimeKind.Unspecified), "Juan", false, "Perez", "098654123", "img\\tattoo\\IronMaiden.jpeg", new DateTime(2021, 12, 5, 9, 30, 0, 0, DateTimeKind.Unspecified), 0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 10.0, 15.0, new Guid("1497eb69-419f-40d4-bde3-a40a0fdb99b0") },
                    { new Guid("c083623f-ec5b-4d28-8bcb-a4b2f1cf053b"), new DateTime(2021, 12, 9, 15, 30, 0, 0, DateTimeKind.Unspecified), "Natalia", false, "Sosa", "0987549823", null, new DateTime(2021, 12, 9, 12, 30, 0, 0, DateTimeKind.Unspecified), 1, "Lorem ipsum it ments", 10.0, 15.0, new Guid("22e1eaa2-bf97-4c83-8af6-84eb303f8a56") }
                });

            migrationBuilder.InsertData(
                table: "BlogItems",
                columns: new[] { "BlogId", "BlogPostId", "Date", "Summary", "Title" },
                values: new object[,]
                {
                    { new Guid("be91104c-514a-4392-979d-8b6960b4a868"), new Guid("26b7976a-7f88-402d-a96c-d15ca965c012"), new DateTime(2020, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. t aliquip ex ea commodo consequat.", "Cuidados del Tattoo" },
                    { new Guid("84e9d9ee-0999-4dd7-8292-87c608a7d418"), new Guid("b761b9f5-c046-405a-ab0c-ae4352731991"), new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.ut aliquip ex ea commodo consequat.", "Cuidados del Piercing" },
                    { new Guid("7431fb9d-cf01-4f68-8f55-e91f8582ac39"), new Guid("cca45a43-e80d-46c8-9e34-a4daeffd460f"), new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.ut aliquip ex ea commodo consequat.", "Sorteos" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_UserId",
                table: "Appointments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogItems_BlogPostId",
                table: "BlogItems",
                column: "BlogPostId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "AppointmentStatus");

            migrationBuilder.DropTable(
                name: "BlogItems");

            migrationBuilder.DropTable(
                name: "PreviousTattooData");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Videos");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "BlogPosts");
        }
    }
}
