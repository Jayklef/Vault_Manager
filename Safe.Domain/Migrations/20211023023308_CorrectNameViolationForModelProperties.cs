using Microsoft.EntityFrameworkCore.Migrations;

namespace Safe.Domain.Migrations
{
    public partial class CorrectNameViolationForModelProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "itemName",
                table: "Items",
                newName: "ItemName");

            migrationBuilder.RenameColumn(
                name: "itemDescription",
                table: "Items",
                newName: "ItemDescription");

            migrationBuilder.RenameColumn(
                name: "currentValue",
                table: "Items",
                newName: "CurrentValue");

            migrationBuilder.RenameColumn(
                name: "itemId",
                table: "Items",
                newName: "ItemId");

            migrationBuilder.RenameColumn(
                name: "categoryName",
                table: "Categories",
                newName: "CategoryName");

            migrationBuilder.RenameColumn(
                name: "amountPerMonth",
                table: "Categories",
                newName: "AmountPerMonth");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Categories",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "staffNumber",
                table: "AccountManagers",
                newName: "StaffNumber");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "AccountManagers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "AccountManagers",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ItemName",
                table: "Items",
                newName: "itemName");

            migrationBuilder.RenameColumn(
                name: "ItemDescription",
                table: "Items",
                newName: "itemDescription");

            migrationBuilder.RenameColumn(
                name: "CurrentValue",
                table: "Items",
                newName: "currentValue");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "Items",
                newName: "itemId");

            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "Categories",
                newName: "categoryName");

            migrationBuilder.RenameColumn(
                name: "AmountPerMonth",
                table: "Categories",
                newName: "amountPerMonth");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Categories",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "StaffNumber",
                table: "AccountManagers",
                newName: "staffNumber");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "AccountManagers",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AccountManagers",
                newName: "id");
        }
    }
}
