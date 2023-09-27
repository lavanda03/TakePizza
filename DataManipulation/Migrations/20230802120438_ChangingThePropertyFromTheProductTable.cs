using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataManipulation.Migrations
{
    /// <inheritdoc />
    public partial class ChangingThePropertyFromTheProductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Code",
                table: "Products",
                newName: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "Code");
        }
    }
}
