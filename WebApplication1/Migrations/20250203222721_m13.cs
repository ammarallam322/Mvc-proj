using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class m13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "Name", "degree", "deptId", "hours", "minDegree" },
                values: new object[,]
                {
                    { 3, "Linq", 100, 1, 30, 60 },
                    { 4, "Entity framework", 100, 2, 30, 60 },
                    { 5, "js", 100, 1, 30, 60 },
                    { 6, "css", 100, 2, 30, 60 },
                    { 7, "network", 100, 2, 30, 60 }
                });

            migrationBuilder.InsertData(
                table: "Trainees",
                columns: new[] { "Id", "Name", "address", "deptId", "grade", "imageUrl" },
                values: new object[,]
                {
                    { 3, "ammar allam ", "tala", 1, 90, "1.gif" },
                    { 4, "ahmed elsobkey", "elbagor", 1, 49, "1.gif" },
                    { 5, "ammar allam ", "tala", 1, 90, "1.gif" },
                    { 6, "ahmed elsobkey", "elbagor", 1, 49, "1.gif" },
                    { 7, "ammar allam ", "tala", 1, 90, "1.gif" },
                    { 8, "ahmed elsobkey", "elbagor", 1, 49, "1.gif" }
                });

            migrationBuilder.InsertData(
                table: "courseResults",
                columns: new[] { "id", "Crs_id", "degree", "trainee_id" },
                values: new object[,]
                {
                    { 3, 2, "90", 3 },
                    { 4, 2, "49", 4 },
                    { 5, 3, "90", 5 },
                    { 6, 3, "49", 6 },
                    { 7, 4, "90", 7 },
                    { 8, 4, "49", 8 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "courseResults",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "courseResults",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "courseResults",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "courseResults",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "courseResults",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "courseResults",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
