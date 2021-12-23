using Microsoft.EntityFrameworkCore.Migrations;

namespace BagLib.Migrations
{
    public partial class market_stocks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Stock_MarketId",
                table: "Stock",
                column: "MarketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_Market_MarketId",
                table: "Stock",
                column: "MarketId",
                principalTable: "Market",
                principalColumn: "MarketId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stock_Market_MarketId",
                table: "Stock");

            migrationBuilder.DropIndex(
                name: "IX_Stock_MarketId",
                table: "Stock");
        }
    }
}
