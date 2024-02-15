using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mission6EmilyPeterson.Migrations
{
    /// <inheritdoc />
    public partial class Initial3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Director",
                table: "Forms",
                newName: "DirectorLast");

            migrationBuilder.AddColumn<string>(
                name: "DirectorFirst",
                table: "Forms",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DirectorFirst",
                table: "Forms");

            migrationBuilder.RenameColumn(
                name: "DirectorLast",
                table: "Forms",
                newName: "Director");
        }
    }
}
