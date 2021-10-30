using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace PMS.Migrations
{
    public partial class material1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.CreateTable(
                name: "Material",
                columns: table => new
                {
                    MaterialID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    SupplierID = table.Column<int>(type: "int", nullable: false),
                    MeasureType = table.Column<string>(type: "text", nullable: true),
                    Quantity = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Material", x => x.MaterialID);
                    table.ForeignKey(
                        name: "FK_Material_Supplier_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Supplier",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Material_SupplierID",
                table: "Material",
                column: "SupplierID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Material");

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    ItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    MeasureType = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Quantity = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    SupplierID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.ItemID);
                    table.ForeignKey(
                        name: "FK_Item_Supplier_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Supplier",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Item_SupplierID",
                table: "Item",
                column: "SupplierID");
        }
    }
}
