using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class mv1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 1,
                column: "grade",
                value: 70);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "grade" },
                values: new object[] { "ali saad ", 94 });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "grade" },
                values: new object[] { "maged mohamed", 30 });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "grade" },
                values: new object[] { "samy ali ", 84 });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Name", "grade" },
                values: new object[] { "wael nagy", 80 });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Name", "grade" },
                values: new object[] { "nader ibrahim ", 77 });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "grade" },
                values: new object[] { "zeyad ahmed", 55 });

            migrationBuilder.UpdateData(
                table: "courseResults",
                keyColumn: "id",
                keyValue: 1,
                column: "degree",
                value: "70");

            migrationBuilder.UpdateData(
                table: "courseResults",
                keyColumn: "id",
                keyValue: 4,
                column: "degree",
                value: "79");

            migrationBuilder.UpdateData(
                table: "courseResults",
                keyColumn: "id",
                keyValue: 5,
                column: "degree",
                value: "50");

            migrationBuilder.UpdateData(
                table: "courseResults",
                keyColumn: "id",
                keyValue: 6,
                column: "degree",
                value: "39");

            migrationBuilder.UpdateData(
                table: "courseResults",
                keyColumn: "id",
                keyValue: 7,
                column: "degree",
                value: "77");

            migrationBuilder.UpdateData(
                table: "courseResults",
                keyColumn: "id",
                keyValue: 8,
                column: "degree",
                value: "59");

         
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "courseResults",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 1,
                column: "grade",
                value: 90);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "grade" },
                values: new object[] { "ammar allam ", 90 });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "grade" },
                values: new object[] { "ahmed elsobkey", 49 });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "grade" },
                values: new object[] { "ammar allam ", 90 });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Name", "grade" },
                values: new object[] { "ahmed elsobkey", 49 });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Name", "grade" },
                values: new object[] { "ammar allam ", 90 });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "grade" },
                values: new object[] { "ahmed elsobkey", 49 });

            migrationBuilder.UpdateData(
                table: "courseResults",
                keyColumn: "id",
                keyValue: 1,
                column: "degree",
                value: "90");

            migrationBuilder.UpdateData(
                table: "courseResults",
                keyColumn: "id",
                keyValue: 4,
                column: "degree",
                value: "49");

            migrationBuilder.UpdateData(
                table: "courseResults",
                keyColumn: "id",
                keyValue: 5,
                column: "degree",
                value: "90");

            migrationBuilder.UpdateData(
                table: "courseResults",
                keyColumn: "id",
                keyValue: 6,
                column: "degree",
                value: "49");

            migrationBuilder.UpdateData(
                table: "courseResults",
                keyColumn: "id",
                keyValue: 7,
                column: "degree",
                value: "90");

            migrationBuilder.UpdateData(
                table: "courseResults",
                keyColumn: "id",
                keyValue: 8,
                column: "degree",
                value: "49");
        }
    }
}
