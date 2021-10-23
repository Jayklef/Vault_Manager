using Microsoft.EntityFrameworkCore.Migrations;

namespace Safe.Domain.Migrations
{
    public partial class AddClientToAccountManagerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccountManagerId",
                table: "Clients",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clients_AccountManagerId",
                table: "Clients",
                column: "AccountManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_AccountManagers_AccountManagerId",
                table: "Clients",
                column: "AccountManagerId",
                principalTable: "AccountManagers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_AccountManagers_AccountManagerId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_AccountManagerId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "AccountManagerId",
                table: "Clients");
        }
    }
}
