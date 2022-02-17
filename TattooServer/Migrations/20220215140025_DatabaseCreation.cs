using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TattooServer.Migrations
{
    public partial class DatabaseCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogPosts",
                columns: table => new
                {
                    BlogPostId = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(maxLength: 2000, nullable: false),
                    Pinned = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPosts", x => x.BlogPostId);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientId = table.Column<Guid>(nullable: false),
                    Email = table.Column<string>(maxLength: 200, nullable: false),
                    FirstName = table.Column<string>(maxLength: 100, nullable: false),
                    LastName = table.Column<string>(maxLength: 100, nullable: false),
                    Phone = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 150, nullable: false),
                    Category = table.Column<string>(maxLength: 50, nullable: false),
                    ImageSource = table.Column<string>(maxLength: 500, nullable: true),
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
                    IsAdmin = table.Column<bool>(nullable: false)
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
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Summary = table.Column<string>(maxLength: 150, nullable: false),
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
                    StatusId = table.Column<int>(nullable: false),
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
                    Status = table.Column<int>(nullable: false)
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
                table: "Users",
                columns: new[] { "UserId", "Email", "IsAdmin", "Password" },
                values: new object[,]
                {
                    { new Guid("ff645d53-55a0-4340-ab6f-cffe1b7d29d9"), "ekaEpitafio@gmail.com", true, "eka666" },
                    { new Guid("00ac69d0-61cb-4c77-b6d4-5119633e0cba"), "gastmartinez85@gmail.com", true, "gaston666" },
                    { new Guid("4f3a3d6c-684f-4faf-8aef-ba53cbfafc8d"), "brian@noemail.com", false, "elBrian" },
                    { new Guid("098fa9c5-6e5f-4f9f-8cba-98ae0c0e6ae9"), "testuser@gmail.com", false, "test111" },
                    { new Guid("644897dc-f357-4f24-9005-8c9248f240bf"), "kimberly@gmail.com", false, "kim111" },
                    { new Guid("d6ef09bb-1b3e-46bd-a7b8-8cccdb9d1684"), "shrek@gmail.com", false, "shrek111" },
                    { new Guid("6056decf-403c-4a72-b047-f1a614936b07"), "fionna@gmail.com", false, "fiona111" },
                    { new Guid("471d579c-9b8d-46f9-bee4-43cad5b81212"), "maicol@gmail.com", false, "maicol111" },
                    { new Guid("ac21e66d-2af4-491c-b77d-95780167e06a"), "jenny@gmail.com", false, "jenny111" }
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
                name: "BlogItems");

            migrationBuilder.DropTable(
                name: "Clients");

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
