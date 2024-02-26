using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace supports.Migrations
{
    /// <inheritdoc />
    public partial class seedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_Company_CompId",
                table: "products");

            migrationBuilder.RenameColumn(
                name: "CompId",
                table: "products",
                newName: "CompanyID");

            migrationBuilder.RenameIndex(
                name: "IX_products_CompId",
                table: "products",
                newName: "IX_products_CompanyID");

            migrationBuilder.AddForeignKey(
                name: "FK_products_Company_CompanyID",
                table: "products",
                column: "CompanyID",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_Company_CompanyID",
                table: "products");

            migrationBuilder.RenameColumn(
                name: "CompanyID",
                table: "products",
                newName: "CompId");

            migrationBuilder.RenameIndex(
                name: "IX_products_CompanyID",
                table: "products",
                newName: "IX_products_CompId");

            migrationBuilder.AddForeignKey(
                name: "FK_products_Company_CompId",
                table: "products",
                column: "CompId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
