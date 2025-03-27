using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Data.Migrations
{
    public partial class changeStation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "pharmacistId",
                table: "stations",
                type: "bigint",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_stations_pharmacists_pharmacistId",
                table: "stations");

            migrationBuilder.DropIndex(
                name: "IX_stations_pharmacistId",
                table: "stations");

            migrationBuilder.DropColumn(
                name: "pharmacistId",
                table: "stations");
        }
    }
}
