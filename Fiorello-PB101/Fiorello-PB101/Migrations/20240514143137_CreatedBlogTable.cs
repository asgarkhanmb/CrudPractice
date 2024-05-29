using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fiorello_PB101.Migrations
{
    public partial class CreatedBlogTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "CreatedDate", "Description", "Image", "SoftDeleted", "Title" },
                values: new object[] { 1, new DateTime(2024, 5, 14, 18, 31, 36, 922, DateTimeKind.Local).AddTicks(1645), "Reshadin Blogu", "blog-feature-img-1.jpg", false, "Title1" });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "CreatedDate", "Description", "Image", "SoftDeleted", "Title" },
                values: new object[] { 2, new DateTime(2024, 5, 14, 18, 31, 36, 922, DateTimeKind.Local).AddTicks(1649), "Ilqarin Blogu", "blog-feature-img-3.jpg", false, "Title2" });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "CreatedDate", "Description", "Image", "SoftDeleted", "Title" },
                values: new object[] { 3, new DateTime(2024, 5, 14, 18, 31, 36, 922, DateTimeKind.Local).AddTicks(1652), "Hacixanin Blogu", "blog-feature-img-4.jpg", false, "Title3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");
        }
    }
}
