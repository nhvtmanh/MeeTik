using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicEvent.Migrations
{
    /// <inheritdoc />
    public partial class AddImageUrlColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "MusicEvents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "MusicEvents");
        }
    }
}
