using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clinic.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ReceptionistToAppointment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReceptionistId",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_ReceptionistId",
                table: "Appointments",
                column: "ReceptionistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Receptionists_ReceptionistId",
                table: "Appointments",
                column: "ReceptionistId",
                principalTable: "Receptionists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Receptionists_ReceptionistId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_ReceptionistId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "ReceptionistId",
                table: "Appointments");
        }
    }
}
