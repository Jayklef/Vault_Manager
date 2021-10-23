using Microsoft.EntityFrameworkCore.Migrations;

namespace Safe.Domain.Migrations
{
    public partial class AddItemToClientTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_ClientId",
                table: "Items",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Clients_ClientId",
                table: "Items",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Clients_ClientId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_ClientId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Items");
        }
    }
}
