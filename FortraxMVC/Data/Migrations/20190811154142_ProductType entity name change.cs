using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FortraxMVC.Data.Migrations
{
    public partial class ProductTypeentitynamechange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "ProductType",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "ProductDetailsViewModel",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductType",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Image",
                table: "ProductDetailsViewModel",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
