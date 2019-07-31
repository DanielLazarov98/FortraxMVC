using Microsoft.EntityFrameworkCore.Migrations;

namespace FortraxMVC.Data.Migrations
{
    public partial class ChangeLotteryNameinDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Lotteries_LotteryId",
                table: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lotteries",
                table: "Lotteries");

            migrationBuilder.RenameTable(
                name: "Lotteries",
                newName: "Lottery");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lottery",
                table: "Lottery",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Lottery_LotteryId",
                table: "Tickets",
                column: "LotteryId",
                principalTable: "Lottery",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Lottery_LotteryId",
                table: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lottery",
                table: "Lottery");

            migrationBuilder.RenameTable(
                name: "Lottery",
                newName: "Lotteries");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lotteries",
                table: "Lotteries",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Lotteries_LotteryId",
                table: "Tickets",
                column: "LotteryId",
                principalTable: "Lotteries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
