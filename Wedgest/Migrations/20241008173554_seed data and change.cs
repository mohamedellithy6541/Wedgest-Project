using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Wedgest.Migrations
{
    /// <inheritdoc />
    public partial class seeddataandchange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "userName",
                table: "user",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "id", "age", "job", "userName" },
                values: new object[,]
                {
                    { 1, 0, "admin", "Mohamed" },
                    { 2, 0, "student", "Mostafa" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.AlterColumn<int>(
                name: "userName",
                table: "user",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
