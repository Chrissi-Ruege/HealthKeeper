using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthKeeper.Migrations
{
    /// <inheritdoc />
    public partial class fixedkey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StatsEntries_AspNetUsers_UserId",
                table: "StatsEntries");

            migrationBuilder.DropIndex(
                name: "IX_StatsEntries_UserId",
                table: "StatsEntries");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "StatsEntries",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "StatsEntries",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StatsEntries_UserId",
                table: "StatsEntries",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_StatsEntries_AspNetUsers_UserId",
                table: "StatsEntries",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
