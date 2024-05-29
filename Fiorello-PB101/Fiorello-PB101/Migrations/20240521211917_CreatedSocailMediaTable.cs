using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fiorello_PB101.Migrations
{
    public partial class CreatedSocailMediaTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SocialMedias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 22, 1, 19, 16, 681, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 22, 1, 19, 16, 681, DateTimeKind.Local).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 22, 1, 19, 16, 681, DateTimeKind.Local).AddTicks(4244));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 22, 1, 19, 16, 681, DateTimeKind.Local).AddTicks(4259));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 22, 1, 19, 16, 681, DateTimeKind.Local).AddTicks(4262));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 22, 1, 19, 16, 681, DateTimeKind.Local).AddTicks(4264));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 22, 1, 19, 16, 681, DateTimeKind.Local).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 22, 1, 19, 16, 681, DateTimeKind.Local).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 22, 1, 19, 16, 681, DateTimeKind.Local).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 22, 1, 19, 16, 681, DateTimeKind.Local).AddTicks(4219));

            migrationBuilder.InsertData(
                table: "SocialMedias",
                columns: new[] { "Id", "CreatedDate", "Name", "SoftDeleted", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 22, 1, 19, 16, 681, DateTimeKind.Local).AddTicks(4062), "Instagram", false, "#instagram" },
                    { 2, new DateTime(2024, 5, 22, 1, 19, 16, 681, DateTimeKind.Local).AddTicks(4066), "Facebook", false, "#facebook" },
                    { 3, new DateTime(2024, 5, 22, 1, 19, 16, 681, DateTimeKind.Local).AddTicks(4068), "Linkedin", false, "#lindkedin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SocialMedias");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 17, 53, 0, 293, DateTimeKind.Local).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 17, 53, 0, 293, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 17, 53, 0, 293, DateTimeKind.Local).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 17, 53, 0, 293, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 17, 53, 0, 293, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 17, 53, 0, 293, DateTimeKind.Local).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 17, 53, 0, 293, DateTimeKind.Local).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 17, 53, 0, 293, DateTimeKind.Local).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 17, 53, 0, 293, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 17, 53, 0, 293, DateTimeKind.Local).AddTicks(8053));
        }
    }
}
