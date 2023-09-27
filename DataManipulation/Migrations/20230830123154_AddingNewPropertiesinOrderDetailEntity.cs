using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataManipulation.Migrations
{
    /// <inheritdoc />
    public partial class AddingNewPropertiesinOrderDetailEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedOrder",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedOrder",
                table: "Orders");
        }
    }
}
