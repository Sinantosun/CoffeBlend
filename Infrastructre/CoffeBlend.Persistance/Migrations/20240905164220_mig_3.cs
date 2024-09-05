using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeBlend.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Statistics");

            migrationBuilder.AddColumn<int>(
                name: "Amount1",
                table: "Statistics",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount1",
                table: "Statistics");

            migrationBuilder.AddColumn<string>(
                name: "Amount",
                table: "Statistics",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
