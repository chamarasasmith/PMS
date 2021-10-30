using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class item_table3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Supplier_SupplierID",
                table: "Item");

            migrationBuilder.AlterColumn<int>(
                name: "SupplierID",
                table: "Item",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Supplier_SupplierID",
                table: "Item",
                column: "SupplierID",
                principalTable: "Supplier",
                principalColumn: "SupplierID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Supplier_SupplierID",
                table: "Item");

            migrationBuilder.AlterColumn<int>(
                name: "SupplierID",
                table: "Item",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Supplier_SupplierID",
                table: "Item",
                column: "SupplierID",
                principalTable: "Supplier",
                principalColumn: "SupplierID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
