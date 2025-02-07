using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class m12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "courseResults",
                columns: new[] { "id", "Crs_id", "degree", "trainee_id" },
                values: new object[,]
                {
                    { 1, 1, "90", 1 },
                    { 2, 1, "49", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "courseResults",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "courseResults",
                keyColumn: "id",
                keyValue: 2);
        }
    }
}
