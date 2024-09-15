using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeBlend.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig66 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TableDetail_Products_ProductId",
                table: "TableDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_TableDetail_Tables_TableID",
                table: "TableDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TableDetail",
                table: "TableDetail");

            migrationBuilder.RenameTable(
                name: "TableDetail",
                newName: "tableDetails");

            migrationBuilder.RenameIndex(
                name: "IX_TableDetail_TableID",
                table: "tableDetails",
                newName: "IX_tableDetails_TableID");

            migrationBuilder.RenameIndex(
                name: "IX_TableDetail_ProductId",
                table: "tableDetails",
                newName: "IX_tableDetails_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tableDetails",
                table: "tableDetails",
                column: "TableDetailID");

            migrationBuilder.AddForeignKey(
                name: "FK_tableDetails_Products_ProductId",
                table: "tableDetails",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tableDetails_Tables_TableID",
                table: "tableDetails",
                column: "TableID",
                principalTable: "Tables",
                principalColumn: "TableID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tableDetails_Products_ProductId",
                table: "tableDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_tableDetails_Tables_TableID",
                table: "tableDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tableDetails",
                table: "tableDetails");

            migrationBuilder.RenameTable(
                name: "tableDetails",
                newName: "TableDetail");

            migrationBuilder.RenameIndex(
                name: "IX_tableDetails_TableID",
                table: "TableDetail",
                newName: "IX_TableDetail_TableID");

            migrationBuilder.RenameIndex(
                name: "IX_tableDetails_ProductId",
                table: "TableDetail",
                newName: "IX_TableDetail_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TableDetail",
                table: "TableDetail",
                column: "TableDetailID");

            migrationBuilder.AddForeignKey(
                name: "FK_TableDetail_Products_ProductId",
                table: "TableDetail",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TableDetail_Tables_TableID",
                table: "TableDetail",
                column: "TableID",
                principalTable: "Tables",
                principalColumn: "TableID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
