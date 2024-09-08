using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeBlend.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Reservations_ReservationsReservationId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_ReservationsReservationId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "ReservationsReservationId",
                table: "Reservations");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReservationsReservationId",
                table: "Reservations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ReservationsReservationId",
                table: "Reservations",
                column: "ReservationsReservationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Reservations_ReservationsReservationId",
                table: "Reservations",
                column: "ReservationsReservationId",
                principalTable: "Reservations",
                principalColumn: "ReservationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
