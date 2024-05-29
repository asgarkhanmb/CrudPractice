using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fiorello_PB101.Migrations
{
    public partial class CreatedExpertTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Experts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experts", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 14, 19, 22, 28, 193, DateTimeKind.Local).AddTicks(7064));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 14, 19, 22, 28, 193, DateTimeKind.Local).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 14, 19, 22, 28, 193, DateTimeKind.Local).AddTicks(7069));

            migrationBuilder.InsertData(
                table: "Experts",
                columns: new[] { "Id", "CreatedDate", "Image", "Name", "Position", "SoftDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 14, 19, 22, 28, 193, DateTimeKind.Local).AddTicks(7200), "h3-team-img-1.png", "CRYSTAL BROOKS", "Florist", false },
                    { 2, new DateTime(2024, 5, 14, 19, 22, 28, 193, DateTimeKind.Local).AddTicks(7202), "h3-team-img-2.png", "SHIRLEY HARRIS", "Manager", false },
                    { 3, new DateTime(2024, 5, 14, 19, 22, 28, 193, DateTimeKind.Local).AddTicks(7204), "h3-team-img-3.png", "BEVERLY CLARK", "Florist", false },
                    { 4, new DateTime(2024, 5, 14, 19, 22, 28, 193, DateTimeKind.Local).AddTicks(7205), "h3-team-img-4.png", "AMANDA WATKINS", "Florist", false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Experts");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 14, 18, 31, 36, 922, DateTimeKind.Local).AddTicks(1645));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 14, 18, 31, 36, 922, DateTimeKind.Local).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 14, 18, 31, 36, 922, DateTimeKind.Local).AddTicks(1652));
        }
    }
}
