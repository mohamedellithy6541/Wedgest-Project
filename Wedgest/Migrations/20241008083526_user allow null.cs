using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wedgest.Migrations
{
    /// <inheritdoc />
    public partial class userallownull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_user_userId",
                table: "Ticket");

            migrationBuilder.AlterColumn<int>(
                name: "userId",
                table: "Ticket",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_user_userId",
                table: "Ticket",
                column: "userId",
                principalTable: "user",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_user_userId",
                table: "Ticket");

            migrationBuilder.AlterColumn<int>(
                name: "userId",
                table: "Ticket",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_user_userId",
                table: "Ticket",
                column: "userId",
                principalTable: "user",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
