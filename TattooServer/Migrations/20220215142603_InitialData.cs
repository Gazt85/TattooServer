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
                columns: new[] { "AppointmenId", "EndDatetime", "FirstName", "HasPreviousTattoos", "LastName", "Phone", "Photo", "StartDateTime", "Status", "StatusId", "TattooDescription", "TattooHeight", "TattooWidth", "UserId" },
                values: new object[,]
                {
                    { new Guid("e22c5d2c-e98a-44b2-91e0-1a1397317901"), new DateTime(2021, 12, 5, 10, 30, 0, 0, DateTimeKind.Unspecified), "Juan", false, "Perez", "098654123", "img\\tattoo\\IronMaiden.jpeg", new DateTime(2021, 12, 5, 9, 30, 0, 0, DateTimeKind.Unspecified), 0, 0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 10.0, 15.0, new Guid("4f3a3d6c-684f-4faf-8aef-ba53cbfafc8d") },
                    { new Guid("e66c2ad3-2be8-43bb-95f8-edce81b46f1a"), new DateTime(2021, 12, 8, 19, 30, 0, 0, DateTimeKind.Unspecified), "Brian", true, "Rodriguez", "098456123", null, new DateTime(2021, 12, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, "Lorem ipsum it ments saab dolore ullamco laboris nisi ut", 30.0, 20.0, new Guid("098fa9c5-6e5f-4f9f-8cba-98ae0c0e6ae9") },
                    { new Guid("3bf3b353-6c41-478f-b5e9-73ba70979942"), new DateTime(2021, 12, 17, 17, 30, 0, 0, DateTimeKind.Unspecified), "Sofia", false, "Sanchez", "098753159", "img\\tattoo\\IronMaiden.jpeg", new DateTime(2021, 12, 17, 15, 30, 0, 0, DateTimeKind.Unspecified), 0, 1, "Lorem ipsum it ments saab dolore ullamco laboris nisi ut", 10.0, 15.0, new Guid("644897dc-f357-4f24-9005-8c9248f240bf") },
                    { new Guid("9d797c0e-3280-4434-8a55-8055221a279c"), new DateTime(2021, 12, 7, 16, 30, 0, 0, DateTimeKind.Unspecified), "Lucas", true, "Padilla", "098654442", null, new DateTime(2021, 12, 7, 15, 30, 0, 0, DateTimeKind.Unspecified), 0, 0, "Lorem ipsum it ments saab dolore ullamco laboris nisi ut", 10.0, 15.0, new Guid("d6ef09bb-1b3e-46bd-a7b8-8cccdb9d1684") },
                    { new Guid("a5008a5a-1d56-4b65-80fd-d8b5da9772b5"), new DateTime(2021, 12, 7, 15, 30, 0, 0, DateTimeKind.Unspecified), "Diego", false, "Lopez", "098652523", null, new DateTime(2021, 12, 7, 14, 30, 0, 0, DateTimeKind.Unspecified), 0, 0, "Lorem ipsum it ments", 10.0, 15.0, new Guid("6056decf-403c-4a72-b047-f1a614936b07") },
                    { new Guid("c083623f-ec5b-4d28-8bcb-a4b2f1cf053b"), new DateTime(2021, 12, 9, 15, 30, 0, 0, DateTimeKind.Unspecified), "Natalia", false, "Sosa", "0987549823", null, new DateTime(2021, 12, 9, 12, 30, 0, 0, DateTimeKind.Unspecified), 0, 1, "Lorem ipsum it ments", 10.0, 15.0, new Guid("471d579c-9b8d-46f9-bee4-43cad5b81212") }
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
                table: "Clients",
                columns: new[] { "ClientId", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { new Guid("dce4cc19-3132-4d6d-97d2-f44b80db68f5"), "testuser@gmail.com", "Test", "User", "098123123" },
                    { new Guid("e3486c1d-9d99-49f2-9838-b87d4bd4d13b"), "brian@noemail.com", "Brian", "Rodriguez", "098123123" }
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
                    { new Guid("85899333-5f20-4e30-9da7-7dc66c3dd198"), "Merchandising", "This is a wider card with supporting text below as a natural lead-in to additional content.", "img\\merch\\Mug.png", "Taza Personalizada", 500m }
                });

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "VideoId", "Date", "Description", "ImageSource", "Link", "Title" },
                values: new object[,]
                {
                    { new Guid("ab3279b1-2480-44ce-8359-4a5ef7607851"), new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is a wider card with supporting text below as a natural lead-in to additional content.", null, "https://www.youtube.com/watch?v=PyYlB_MVuLM", "The Witcher" },
                    { new Guid("9be62997-bfc2-4096-a539-c13665553742"), new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is a wider card with supporting text below as a natural lead-in to additional content.", null, "https://www.youtube.com/watch?v=0HU1rMDGyB8&t=202s", "Tyranny" },
                    { new Guid("71bb9b15-a5f2-477f-8d7a-970befbeefea"), new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is a wider card with supporting text below as a natural lead-in to additional content", "img\\Eka logo.jpeg", "https://www.youtube.com/watch?v=BL2NHqc74sQ&ab_channel=NERIUMOFFICIALNERIUMOFFICIAL", "Nerium" },
                    { new Guid("4f826a82-a14c-44b7-af18-40c81b021555"), new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is a wider card with supporting text below as a natural lead-in to additional content.", "img\\tattoo\\leon.jpeg", "https://www.youtube.com/watch?v=f5jGX9A6ErA&ab_channel=JAZZ%26BLUESJAZZ%26BLUES", "Whiskey Blues" },
                    { new Guid("bc449310-7897-4d68-b20e-2b659cb97b81"), new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is a wider card with supporting text below as a natural lead-in to additional content.", "img\\Eka logo.jpeg", "https://www.youtube.com/watch?v=m3HZKHTLHDU&ab_channel=RptimaoTV2RptimaoTV2", "Bra vs Ger" },
                    { new Guid("a38f6a79-0964-4b02-aeeb-0ae441121f12"), new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is a wider card with supporting text below as a natural lead-in to additional content.", null, "https://www.youtube.com/watch?v=NQ1n5KHTAvo&ab_channel=Shane", "Breaking Bad" }
                });

            migrationBuilder.InsertData(
                table: "BlogItems",
                columns: new[] { "BlogId", "BlogPostId", "Date", "Summary", "Title" },
                values: new object[] { new Guid("be91104c-514a-4392-979d-8b6960b4a868"), new Guid("26b7976a-7f88-402d-a96c-d15ca965c012"), new DateTime(2020, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et vel dignissim hendrerit at lorem lorem kasd accusam nibh diam takimata dolor et justo option takimata", "Cuidados del Tattoo" });

            migrationBuilder.InsertData(
                table: "BlogItems",
                columns: new[] { "BlogId", "BlogPostId", "Date", "Summary", "Title" },
                values: new object[] { new Guid("84e9d9ee-0999-4dd7-8292-87c608a7d418"), new Guid("b761b9f5-c046-405a-ab0c-ae4352731991"), new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et vel dignissim hendrerit at lorem lorem kasd accusam nibh diam takimata dolor et justo option takimata", "Cuidados del Piercing" });

            migrationBuilder.InsertData(
                table: "BlogItems",
                columns: new[] { "BlogId", "BlogPostId", "Date", "Summary", "Title" },
                values: new object[] { new Guid("7431fb9d-cf01-4f68-8f55-e91f8582ac39"), new Guid("cca45a43-e80d-46c8-9e34-a4daeffd460f"), new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et vel dignissim hendrerit at lorem lorem kasd accusam nibh diam takimata dolor et justo option takimata", "Sorteos" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppointmentStatus");

            migrationBuilder.DropTable(
                name: "PreviousTattooData");

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
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("dce4cc19-3132-4d6d-97d2-f44b80db68f5"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("e3486c1d-9d99-49f2-9838-b87d4bd4d13b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("52c007e5-4b58-4e61-91fc-b8b95a430bb9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("59cc79df-7ea9-4a4a-ab2b-5e598014152b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("85899333-5f20-4e30-9da7-7dc66c3dd198"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f749e0cd-1917-401e-a8da-27e2d88da463"));

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: new Guid("4f826a82-a14c-44b7-af18-40c81b021555"));

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: new Guid("71bb9b15-a5f2-477f-8d7a-970befbeefea"));

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: new Guid("9be62997-bfc2-4096-a539-c13665553742"));

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: new Guid("a38f6a79-0964-4b02-aeeb-0ae441121f12"));

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: new Guid("ab3279b1-2480-44ce-8359-4a5ef7607851"));

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: new Guid("bc449310-7897-4d68-b20e-2b659cb97b81"));

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
        }
    }
}
