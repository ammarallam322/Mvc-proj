using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "crs_id",
                table: "Instructors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_crs_id",
                table: "Instructors",
                column: "crs_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Course_crs_id",
                table: "Instructors",
                column: "crs_id",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Course_crs_id",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_crs_id",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "crs_id",
                table: "Instructors");
        }
    }
}
