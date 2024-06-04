using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthKeeper.Migrations
{
    /// <inheritdoc />
    public partial class Addedfoodjournal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StatsEntries_AspNetUsers_UserId",
                table: "StatsEntries");

            migrationBuilder.AlterColumn<double>(
                name: "Weight",
                table: "StatsEntries",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "StatsEntries",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<double>(
                name: "Height",
                table: "StatsEntries",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.CreateTable(
                name: "FoodJournalEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Calories = table.Column<float>(type: "real", nullable: false),
                    Fat = table.Column<float>(type: "real", nullable: false),
                    Protein = table.Column<float>(type: "real", nullable: false),
                    Sugar = table.Column<float>(type: "real", nullable: false),
                    Carbs = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodJournalEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodJournalEntries_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodJournalEntries_UserId",
                table: "FoodJournalEntries",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_StatsEntries_AspNetUsers_UserId",
                table: "StatsEntries",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StatsEntries_AspNetUsers_UserId",
                table: "StatsEntries");

            migrationBuilder.DropTable(
                name: "FoodJournalEntries");

            migrationBuilder.AlterColumn<float>(
                name: "Weight",
                table: "StatsEntries",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "StatsEntries",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "Height",
                table: "StatsEntries",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddForeignKey(
                name: "FK_StatsEntries_AspNetUsers_UserId",
                table: "StatsEntries",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
