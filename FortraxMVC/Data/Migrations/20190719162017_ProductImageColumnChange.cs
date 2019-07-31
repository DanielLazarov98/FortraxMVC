using Microsoft.EntityFrameworkCore.Migrations;

namespace FortraxMVC.Data.Migrations
{
    public partial class ProductImageColumnChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Picture",
                table: "Products",
                newName: "Image");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Products",
                newName: "Picture");
        }
    }
}
