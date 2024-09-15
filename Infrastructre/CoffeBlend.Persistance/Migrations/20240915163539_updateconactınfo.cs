using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeBlend.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class updateconactınfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "ContactInfos",
                newName: "Title3");

            migrationBuilder.RenameColumn(
                name: "Icon",
                table: "ContactInfos",
                newName: "Title2");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "ContactInfos",
                newName: "Title1");

            migrationBuilder.AddColumn<string>(
                name: "Description1",
                table: "ContactInfos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description2",
                table: "ContactInfos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description3",
                table: "ContactInfos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Icon1",
                table: "ContactInfos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Icon2",
                table: "ContactInfos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Icon3",
                table: "ContactInfos",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description1",
                table: "ContactInfos");

            migrationBuilder.DropColumn(
                name: "Description2",
                table: "ContactInfos");

            migrationBuilder.DropColumn(
                name: "Description3",
                table: "ContactInfos");

            migrationBuilder.DropColumn(
                name: "Icon1",
                table: "ContactInfos");

            migrationBuilder.DropColumn(
                name: "Icon2",
                table: "ContactInfos");

            migrationBuilder.DropColumn(
                name: "Icon3",
                table: "ContactInfos");

            migrationBuilder.RenameColumn(
                name: "Title3",
                table: "ContactInfos",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Title2",
                table: "ContactInfos",
                newName: "Icon");

            migrationBuilder.RenameColumn(
                name: "Title1",
                table: "ContactInfos",
                newName: "Description");
        }
    }
}
