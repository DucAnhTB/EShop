using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 5, 8, 6, 526, DateTimeKind.Local).AddTicks(1563),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 11, 4, 48, 28, 259, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("e2d0051a-439a-46ff-93c9-c5129d99878c"), "cfef3320-a2e5-4474-9213-ddd0569b1d91", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("e2d0051a-439a-46ff-93c9-c5129d99878c"), new Guid("e2d0051a-439a-46ff-93c9-c5129d99878c") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("e2d0051a-439a-46ff-93c9-c5129d99878c"), 0, "5247ecf3-6aae-49e4-bbad-0dbde9208a63", new DateTime(2000, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "chauongchan@gmail.com", true, "Duc", "Anh", false, null, "chauongchan@gmail.com", "admin", "AQAAAAEAACcQAAAAEOJw/+IXDVqVL8aMk8kg4ZoHZGpDfzvZk/luDJvTL6q6rbqf8BAUDLX1cKZHm+gLQg==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 11, 5, 8, 6, 548, DateTimeKind.Local).AddTicks(2759));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e2d0051a-439a-46ff-93c9-c5129d99878c"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("e2d0051a-439a-46ff-93c9-c5129d99878c"), new Guid("e2d0051a-439a-46ff-93c9-c5129d99878c") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("e2d0051a-439a-46ff-93c9-c5129d99878c"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 11, 4, 48, 28, 259, DateTimeKind.Local).AddTicks(4260),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 11, 5, 8, 6, 526, DateTimeKind.Local).AddTicks(1563));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 11, 4, 48, 28, 294, DateTimeKind.Local).AddTicks(9791));
        }
    }
}
