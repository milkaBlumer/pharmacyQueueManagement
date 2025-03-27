using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Data.Migrations
{
    public partial class deleteConnect : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_stations_pharmacists_pharmacistId",
                table: "stations");

            migrationBuilder.DropIndex(
                name: "IX_stations_pharmacistId",
                table: "stations");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_stations_pharmacistId",
                table: "stations",
                column: "pharmacistId");

            migrationBuilder.AddForeignKey(
                name: "FK_stations_pharmacists_pharmacistId",
                table: "stations",
                column: "pharmacistId",
                principalTable: "pharmacists",
                principalColumn: "id");
        }
    }
}
