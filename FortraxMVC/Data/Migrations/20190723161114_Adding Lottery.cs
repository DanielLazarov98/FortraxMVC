using Microsoft.EntityFrameworkCore.Migrations;

namespace FortraxMVC.Data.Migrations
{
    public partial class AddingLottery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LotteryWinnerViewModel",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    WinnerId = table.Column<string>(nullable: true),
                    WinningTicketId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LotteryWinnerViewModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LotteryWinnerViewModel_AspNetUsers_WinnerId",
                        column: x => x.WinnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LotteryWinnerViewModel_Tickets_WinningTicketId",
                        column: x => x.WinningTicketId,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LotteryWinnerViewModel_WinnerId",
                table: "LotteryWinnerViewModel",
                column: "WinnerId");

            migrationBuilder.CreateIndex(
                name: "IX_LotteryWinnerViewModel_WinningTicketId",
                table: "LotteryWinnerViewModel",
                column: "WinningTicketId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LotteryWinnerViewModel");
        }
    }
}
