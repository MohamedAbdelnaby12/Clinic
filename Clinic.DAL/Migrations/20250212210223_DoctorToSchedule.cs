using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clinic.DAL.Migrations
{
    /// <inheritdoc />
    public partial class DoctorToSchedule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ScheduleId",
                table: "Doctor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Schedule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    EndTime = table.Column<TimeOnly>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_ScheduleId",
                table: "Doctor",
                column: "ScheduleId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_Schedule_ScheduleId",
                table: "Doctor",
                column: "ScheduleId",
                principalTable: "Schedule",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_Schedule_ScheduleId",
                table: "Doctor");

            migrationBuilder.DropTable(
                name: "Schedule");

            migrationBuilder.DropIndex(
                name: "IX_Doctor_ScheduleId",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "ScheduleId",
                table: "Doctor");
        }
    }
}
