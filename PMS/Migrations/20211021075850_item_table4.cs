using Microsoft.EntityFrameworkCore.Migrations;

namespace PMS.Migrations
{
    public partial class item_table4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MeasureType",
                table: "Item",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Quantity",
                table: "Item",
                type: "decimal(18, 2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MeasureType",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Item");
        }
    }
}
