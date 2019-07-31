using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FortraxMVC.Data.Migrations
{
    public partial class ProductsChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductDetailsViewModelId",
                table: "Comments",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductDetailsViewModel",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Image = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetailsViewModel", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ProductDetailsViewModelId",
                table: "Comments",
                column: "ProductDetailsViewModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_ProductDetailsViewModel_ProductDetailsViewModelId",
                table: "Comments",
                column: "ProductDetailsViewModelId",
                principalTable: "ProductDetailsViewModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_ProductDetailsViewModel_ProductDetailsViewModelId",
                table: "Comments");

            migrationBuilder.DropTable(
                name: "ProductDetailsViewModel");

            migrationBuilder.DropIndex(
                name: "IX_Comments_ProductDetailsViewModelId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "ProductDetailsViewModelId",
                table: "Comments");
        }
    }
}
