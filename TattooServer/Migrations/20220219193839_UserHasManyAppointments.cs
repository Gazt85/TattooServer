using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TattooServer.Migrations
{
    public partial class UserHasManyAppointments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BlogItems",
                keyColumn: "BlogId",
                keyValue: new Guid("84e9d9ee-0999-4dd7-8292-87c608a7d418"),
                column: "Summary",
                value: "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. ");

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: new Guid("b809488c-0037-4adc-9d2f-89dcaa65758b"),
                column: "Description",
                value: "This is a wider card with supporting text below as a natural lead-in to additional content");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BlogItems",
                keyColumn: "BlogId",
                keyValue: new Guid("84e9d9ee-0999-4dd7-8292-87c608a7d418"),
                column: "Summary",
                value: "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.");

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "VideoId",
                keyValue: new Guid("b809488c-0037-4adc-9d2f-89dcaa65758b"),
                column: "Description",
                value: "This is a wider card with supporting text below as a natural lead-in to additional content.");
        }
    }
}
