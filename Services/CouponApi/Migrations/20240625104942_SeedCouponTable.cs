using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CouponApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedCouponTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "CouponId", "CouponCode", "CouponType", "DiscountAmount", "LastUpdated", "MinAmount" },
                values: new object[,]
                {
                    { 1, "10OFF", 0.0, 10, new DateTime(2024, 6, 25, 12, 49, 41, 943, DateTimeKind.Local).AddTicks(910), 20 },
                    { 2, "20OFF", 0.0, 20, new DateTime(2024, 6, 25, 12, 49, 41, 943, DateTimeKind.Local).AddTicks(980), 40 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: 2);
        }
    }
}
