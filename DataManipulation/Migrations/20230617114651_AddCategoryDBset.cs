using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataManipulation.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoryDBset : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryEntityId",
                table: "Product",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryEntityId",
                table: "Product",
                column: "CategoryEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_CategoryEntityId",
                table: "Product",
                column: "CategoryEntityId",
                principalTable: "Category",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_CategoryEntityId",
                table: "Product");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Product_CategoryEntityId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "CategoryEntityId",
                table: "Product");
        }
    }
}
