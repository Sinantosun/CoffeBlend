using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeBlend.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class inital2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "Tables",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "int2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<short>(
                name: "Status",
                table: "Tables",
                type: "int2",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "smallint");
        }
    }
}
