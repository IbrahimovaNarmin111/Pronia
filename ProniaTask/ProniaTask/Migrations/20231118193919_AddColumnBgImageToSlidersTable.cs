using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProniaTask.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnBgImageToSlidersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BgImage",
                table: "Sliders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BgImage",
                table: "Sliders");
        }
    }
}
