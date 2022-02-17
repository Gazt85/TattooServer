using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TattooServer.Migrations
{
    public partial class InitialData : Migration
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

            migrationBuilder.InsertData(
                table: "AppointmentStatus",
                columns: new[] { "Id", "Color", "Name" },
                values: new object[,]
                {
                    { 1, "#ea7a57", "Tentativo" },
                    { 2, "#7fa900", "Confirmado" }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmenId", "Email", "EndDatetime", "FirstName", "HasPreviousTattoos", "LastName", "Phone", "Photo", "StartDateTime", "StatusId", "TattooDescription", "TattooHeight", "TattooWidth" },
                values: new object[,]
                {
                    { new Guid("e22c5d2c-e98a-44b2-91e0-1a1397317901"), "juan@noemail.com", new DateTime(2021, 12, 5, 10, 30, 0, 0, DateTimeKind.Unspecified), "Juan", false, "Perez", "098654123", "img\\tattoo\\IronMaiden.jpeg", new DateTime(2021, 12, 5, 9, 30, 0, 0, DateTimeKind.Unspecified), 0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 10.0, 15.0 },
                    { new Guid("3bf3b353-6c41-478f-b5e9-73ba70979942"), "sofia@noemail.com", new DateTime(2021, 12, 17, 17, 30, 0, 0, DateTimeKind.Unspecified), "Sofia", false, "Sanchez", "098753159", "img\\tattoo\\IronMaiden.jpeg", new DateTime(2021, 12, 17, 15, 30, 0, 0, DateTimeKind.Unspecified), 1, "Lorem ipsum it ments saab dolore ullamco laboris nisi ut", 10.0, 15.0 },
                    { new Guid("9d797c0e-3280-4434-8a55-8055221a279c"), "lucas@noemail.com", new DateTime(2021, 12, 7, 16, 30, 0, 0, DateTimeKind.Unspecified), "Lucas", true, "Padilla", "098654442", null, new DateTime(2021, 12, 7, 15, 30, 0, 0, DateTimeKind.Unspecified), 0, "Lorem ipsum it ments saab dolore ullamco laboris nisi ut", 10.0, 15.0 },
                    { new Guid("c083623f-ec5b-4d28-8bcb-a4b2f1cf053b"), "nati@noemail.com", new DateTime(2021, 12, 9, 15, 30, 0, 0, DateTimeKind.Unspecified), "Natalia", false, "Sosa", "0987549823", null, new DateTime(2021, 12, 9, 12, 30, 0, 0, DateTimeKind.Unspecified), 1, "Lorem ipsum it ments", 10.0, 15.0 }
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
                columns: new[] { "Id", "Category", "Description", "ImageSource", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("4aa3bac2-ede7-4411-9619-5e1e2fe67338"), "Merchandising", "This is a wider card with supporting text below as a natural lead-in to additional content.", "img\\merch\\Mug.png", "Taza Personalizada", 500m },
                    { new Guid("59cc79df-7ea9-4a4a-ab2b-5e598014152b"), "Merchandising", "This is a wider card with supporting text below as a natural lead-in to additional content.", "img\\merch\\Vintage.png", "Remera Vintage", 750m },
                    { new Guid("52c007e5-4b58-4e61-91fc-b8b95a430bb9"), "Merchandising", "This is a wider card with supporting text below as a natural lead-in to additional content.", "img\\merch\\RideTheLighting.png", "Remera Ride The Lighting", 600m },
                    { new Guid("f749e0cd-1917-401e-a8da-27e2d88da463"), "Merchandising", "This is a wider card with supporting text below as a natural lead-in to additional content.", "img\\merch\\metallica.png", "Remera Kill em' All", 500m }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "IsAdmin", "Password" },
                values: new object[,]
                {
                    { "ekaEpitafio@gmail.com", true, "eka666" },
                    { "gastmartinez85@gmail.com", true, "gaston666" },
                    { "brian@noemail.com", false, "elBrian" },
                    { "testuser@gmail.com", false, "test111" }
                });

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "VideoId", "Date", "Description", "ImageSource", "Link", "Title" },
                values: new object[,]
                {
                    { new Guid("6c3779fa-7cb5-4a17-9733-65ea91e0d138"), new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is a wider card with supporting text below as a natural lead-in to additional content.", null, "https://www.youtube.com/watch?v=0HU1rMDGyB8&t=202s", "Tyranny" },
                    { new Guid("b809488c-0037-4adc-9d2f-89dcaa65758b"), new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is a wider card with supporting text below as a natural lead-in to additional content.This is a wider card with supporting text below as a natural lead-in to additional content", "img\\Eka logo.jpeg", "https://www.youtube.com/watch?v=BL2NHqc74sQ&ab_channel=NERIUMOFFICIALNERIUMOFFICIAL", "Nerium" },
                    { new Guid("0adf51bc-ceac-49b8-96e8-92e285f59614"), new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is a wider card with supporting text below as a natural lead-in to additional content.", "img\\tattoo\\leon.jpeg", "https://www.youtube.com/watch?v=f5jGX9A6ErA&ab_channel=JAZZ%26BLUESJAZZ%26BLUES", "Whiskey Blues" },
                    { new Guid("b9a9681e-1ce4-498b-ae59-1b76dd8028cf"), new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is a wider card with supporting text below as a natural lead-in to additional content.", "img\\Eka logo.jpeg", "https://www.youtube.com/watch?v=m3HZKHTLHDU&ab_channel=RptimaoTV2RptimaoTV2", "Bra vs Ger" },
                    { new Guid("39611369-a99e-4670-b9fd-6d82d2ed97c4"), new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is a wider card with supporting text below as a natural lead-in to additional content.", null, "https://www.youtube.com/watch?v=PyYlB_MVuLM", "The Witcher" },
                    { new Guid("2c08208a-765b-4b49-b74c-c4b38fd6f655"), new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is a wider card with supporting text below as a natural lead-in to additional content.", null, "https://www.youtube.com/watch?v=NQ1n5KHTAvo&ab_channel=Shane", "Breaking Bad" }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmenId", "Email", "EndDatetime", "FirstName", "HasPreviousTattoos", "LastName", "Phone", "Photo", "StartDateTime", "StatusId", "TattooDescription", "TattooHeight", "TattooWidth" },
                values: new object[,]
                {
                    { new Guid("e66c2ad3-2be8-43bb-95f8-edce81b46f1a"), "brian@noemail.com", new DateTime(2021, 12, 8, 19, 30, 0, 0, DateTimeKind.Unspecified), "Brian", true, "Rodriguez", "098456123", null, new DateTime(2021, 12, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lorem ipsum it ments saab dolore ullamco laboris nisi ut", 30.0, 20.0 },
                    { new Guid("a5008a5a-1d56-4b65-80fd-d8b5da9772b5"), "brian@noemail.com", new DateTime(2021, 12, 7, 15, 30, 0, 0, DateTimeKind.Unspecified), "Diego", false, "Lopez", "098652523", null, new DateTime(2021, 12, 7, 14, 30, 0, 0, DateTimeKind.Unspecified), 0, "Lorem ipsum it ments", 10.0, 15.0 }
                });

            migrationBuilder.InsertData(
                table: "BlogItems",
                columns: new[] { "BlogId", "BlogPostId", "Date", "Summary", "Title" },
                values: new object[,]
                {
                    { new Guid("be91104c-514a-4392-979d-8b6960b4a868"), new Guid("26b7976a-7f88-402d-a96c-d15ca965c012"), new DateTime(2020, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Cuidados del Tattoo" },
                    { new Guid("84e9d9ee-0999-4dd7-8292-87c608a7d418"), new Guid("b761b9f5-c046-405a-ab0c-ae4352731991"), new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Cuidados del Piercing" },
                    { new Guid("7431fb9d-cf01-4f68-8f55-e91f8582ac39"), new Guid("cca45a43-e80d-46c8-9e34-a4daeffd460f"), new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Sorteos" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserId",
                table: "Users",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppointmentStatus");

            migrationBuilder.DropTable(
                name: "PreviousTattooData");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserId",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmenId",
                keyValue: new Guid("3bf3b353-6c41-478f-b5e9-73ba70979942"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmenId",
                keyValue: new Guid("9d797c0e-3280-4434-8a55-8055221a279c"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmenId",
                keyValue: new Guid("a5008a5a-1d56-4b65-80fd-d8b5da9772b5"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmenId",
                keyValue: new Guid("c083623f-ec5b-4d28-8bcb-a4b2f1cf053b"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmenId",
                keyValue: new Guid("e22c5d2c-e98a-44b2-91e0-1a1397317901"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmenId",
                keyValue: new Guid("e66c2ad3-2be8-43bb-95f8-edce81b46f1a"));

            migrationBuilder.DeleteData(
                table: "BlogItems",
                keyColumn: "BlogId",
                keyValue: new Guid("7431fb9d-cf01-4f68-8f55-e91f8582ac39"));

            migrationBuilder.DeleteData(
                table: "BlogItems",
                keyColumn: "BlogId",
                keyValue: new Guid("84e9d9ee-0999-4dd7-8292-87c608a7d418"));

            migrationBuilder.DeleteData(
                table: "BlogItems",
                keyColumn: "BlogId",
                keyValue: new Guid("be91104c-514a-4392-979d-8b6960b4a868"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4aa3bac2-ede7-4411-9619-5e1e2fe67338"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("52c007e5-4b58-4e61-91fc-b8b95a430bb9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("59cc79df-7ea9-4a4a-ab2b-5e598014152b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f749e0cd-1917-401e-a8da-27e2d88da463"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "ekaEpitafio@gmail.com");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "gastmartinez85@gmail.com");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "testuser@gmail.com");

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: new Guid("0adf51bc-ceac-49b8-96e8-92e285f59614"));

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: new Guid("2c08208a-765b-4b49-b74c-c4b38fd6f655"));

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: new Guid("39611369-a99e-4670-b9fd-6d82d2ed97c4"));

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: new Guid("6c3779fa-7cb5-4a17-9733-65ea91e0d138"));

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: new Guid("b809488c-0037-4adc-9d2f-89dcaa65758b"));

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: new Guid("b9a9681e-1ce4-498b-ae59-1b76dd8028cf"));

            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: new Guid("26b7976a-7f88-402d-a96c-d15ca965c012"));

            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: new Guid("b761b9f5-c046-405a-ab0c-ae4352731991"));

            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: new Guid("cca45a43-e80d-46c8-9e34-a4daeffd460f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "brian@noemail.com");
        }
    }
}
