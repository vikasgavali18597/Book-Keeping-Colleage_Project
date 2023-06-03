using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookKeeper.DataStore.Migrations
{
    /// <inheritdoc />
    public partial class Migration_V3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GlNumber",
                table: "Ledgers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GlNumber",
                table: "Ledgers");
        }
    }
}
