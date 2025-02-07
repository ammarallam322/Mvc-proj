using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class m11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_courseResults_Course_courseId",
                table: "courseResults");

            migrationBuilder.DropIndex(
                name: "IX_courseResults_courseId",
                table: "courseResults");

            migrationBuilder.DropColumn(
                name: "courseId",
                table: "courseResults");

            migrationBuilder.InsertData(
                table: "Trainees",
                columns: new[] { "Id", "Name", "address", "deptId", "grade", "imageUrl" },
                values: new object[,]
                {
                    { 1, "ammar allam ", "tala", 1, 90, "1.gif" },
                    { 2, "ahmed elsobkey", "elbagor", 1, 49, "1.gif" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_courseResults_Crs_id",
                table: "courseResults",
                column: "Crs_id");

            migrationBuilder.AddForeignKey(
                name: "FK_courseResults_Course_Crs_id",
                table: "courseResults",
                column: "Crs_id",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_courseResults_Course_Crs_id",
                table: "courseResults");

            migrationBuilder.DropIndex(
                name: "IX_courseResults_Crs_id",
                table: "courseResults");

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AddColumn<int>(
                name: "courseId",
                table: "courseResults",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_courseResults_courseId",
                table: "courseResults",
                column: "courseId");

            migrationBuilder.AddForeignKey(
                name: "FK_courseResults_Course_courseId",
                table: "courseResults",
                column: "courseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
