using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fiorello_PB101.Migrations
{
    public partial class CreatedSettingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedDate", "Key" },
                values: new object[] { new DateTime(2024, 5, 21, 17, 53, 0, 293, DateTimeKind.Local).AddTicks(8047), "HeaderLogo" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 17, 33, 45, 469, DateTimeKind.Local).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 17, 33, 45, 469, DateTimeKind.Local).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 17, 33, 45, 469, DateTimeKind.Local).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 17, 33, 45, 469, DateTimeKind.Local).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 17, 33, 45, 469, DateTimeKind.Local).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 17, 33, 45, 469, DateTimeKind.Local).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 17, 33, 45, 469, DateTimeKind.Local).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Key" },
                values: new object[] { new DateTime(2024, 5, 21, 17, 33, 45, 469, DateTimeKind.Local).AddTicks(6146), "HeaderLog" });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 17, 33, 45, 469, DateTimeKind.Local).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 17, 33, 45, 469, DateTimeKind.Local).AddTicks(6152));
        }
    }
}
