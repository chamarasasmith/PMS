using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace PMS.Migrations
{
    public partial class po3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrderDetails_Item_ItemID",
                table: "PurchaseOrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrderDetails_Location_LocationID",
                table: "PurchaseOrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseOrderDetails_ItemID",
                table: "PurchaseOrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseOrderDetails_LocationID",
                table: "PurchaseOrderDetails");

            migrationBuilder.DropColumn(
                name: "ItemID",
                table: "PurchaseOrderDetails");

            migrationBuilder.DropColumn(
                name: "LocationID",
                table: "PurchaseOrderDetails");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "PurchaseOrderDetails");

            migrationBuilder.AddColumn<long>(
                name: "PurchaseRequisitionID",
                table: "PurchaseOrderDetails",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "PurchaseRequisition",
                columns: table => new
                {
                    PurchaseRequisitionID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ItemID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    LocationID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedByID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseRequisition", x => x.PurchaseRequisitionID);
                    table.ForeignKey(
                        name: "FK_PurchaseRequisition_Item_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Item",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchaseRequisition_Location_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Location",
                        principalColumn: "LocationID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchaseRequisition_User_CreatedByID",
                        column: x => x.CreatedByID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderDetails_PurchaseRequisitionID",
                table: "PurchaseOrderDetails",
                column: "PurchaseRequisitionID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseRequisition_CreatedByID",
                table: "PurchaseRequisition",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseRequisition_ItemID",
                table: "PurchaseRequisition",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseRequisition_LocationID",
                table: "PurchaseRequisition",
                column: "LocationID");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrderDetails_PurchaseRequisition_PurchaseRequisition~",
                table: "PurchaseOrderDetails",
                column: "PurchaseRequisitionID",
                principalTable: "PurchaseRequisition",
                principalColumn: "PurchaseRequisitionID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrderDetails_PurchaseRequisition_PurchaseRequisition~",
                table: "PurchaseOrderDetails");

            migrationBuilder.DropTable(
                name: "PurchaseRequisition");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseOrderDetails_PurchaseRequisitionID",
                table: "PurchaseOrderDetails");

            migrationBuilder.DropColumn(
                name: "PurchaseRequisitionID",
                table: "PurchaseOrderDetails");

            migrationBuilder.AddColumn<int>(
                name: "ItemID",
                table: "PurchaseOrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LocationID",
                table: "PurchaseOrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Quantity",
                table: "PurchaseOrderDetails",
                type: "decimal(18, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderDetails_ItemID",
                table: "PurchaseOrderDetails",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderDetails_LocationID",
                table: "PurchaseOrderDetails",
                column: "LocationID");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrderDetails_Item_ItemID",
                table: "PurchaseOrderDetails",
                column: "ItemID",
                principalTable: "Item",
                principalColumn: "ItemID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrderDetails_Location_LocationID",
                table: "PurchaseOrderDetails",
                column: "LocationID",
                principalTable: "Location",
                principalColumn: "LocationID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
