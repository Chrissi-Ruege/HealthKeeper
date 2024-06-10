using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthKeeper.Migrations
{
    /// <inheritdoc />
    public partial class Fixedforeignkey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "CalendarEntries",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CalendarEntries_UserId",
                table: "CalendarEntries",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CalendarEntries_AspNetUsers_UserId",
                table: "CalendarEntries",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CalendarEntries_AspNetUsers_UserId",
                table: "CalendarEntries");

            migrationBuilder.DropIndex(
                name: "IX_CalendarEntries_UserId",
                table: "CalendarEntries");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "CalendarEntries",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }
    }
}
