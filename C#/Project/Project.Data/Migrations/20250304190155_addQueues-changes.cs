using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Data.Migrations
{
    public partial class addQueueschanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pharmacies",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    manager = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    stationCount = table.Column<int>(type: "int", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    addCounter = table.Column<int>(type: "int", nullable: false),
                    removeCounter = table.Column<int>(type: "int", nullable: false),
                    specialsAddCounter = table.Column<int>(type: "int", nullable: false),
                    specialsRemoveCounter = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pharmacies", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "specials",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tz = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_specials", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "patientsQueues",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    number = table.Column<int>(type: "int", nullable: false),
                    pharmacyId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patientsQueues", x => x.id);
                    table.ForeignKey(
                        name: "FK_patientsQueues_pharmacies_pharmacyId",
                        column: x => x.pharmacyId,
                        principalTable: "pharmacies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pharmacists",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pharmacyId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pharmacists", x => x.id);
                    table.ForeignKey(
                        name: "FK_pharmacists_pharmacies_pharmacyId",
                        column: x => x.pharmacyId,
                        principalTable: "pharmacies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "specialsQueues",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    number = table.Column<int>(type: "int", nullable: false),
                    pharmacyId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_specialsQueues", x => x.id);
                    table.ForeignKey(
                        name: "FK_specialsQueues_pharmacies_pharmacyId",
                        column: x => x.pharmacyId,
                        principalTable: "pharmacies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "stations",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pharmacyId = table.Column<long>(type: "bigint", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stations", x => x.id);
                    table.ForeignKey(
                        name: "FK_stations_pharmacies_pharmacyId",
                        column: x => x.pharmacyId,
                        principalTable: "pharmacies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_patientsQueues_pharmacyId",
                table: "patientsQueues",
                column: "pharmacyId");

            migrationBuilder.CreateIndex(
                name: "IX_pharmacists_pharmacyId",
                table: "pharmacists",
                column: "pharmacyId");

            migrationBuilder.CreateIndex(
                name: "IX_specialsQueues_pharmacyId",
                table: "specialsQueues",
                column: "pharmacyId");

            migrationBuilder.CreateIndex(
                name: "IX_stations_pharmacyId",
                table: "stations",
                column: "pharmacyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "patientsQueues");

            migrationBuilder.DropTable(
                name: "pharmacists");

            migrationBuilder.DropTable(
                name: "specials");

            migrationBuilder.DropTable(
                name: "specialsQueues");

            migrationBuilder.DropTable(
                name: "stations");

            migrationBuilder.DropTable(
                name: "pharmacies");
        }
    }
}
