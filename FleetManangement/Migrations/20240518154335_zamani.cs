using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleetManangement.Migrations
{
    /// <inheritdoc />
    public partial class zamani : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CostCentre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Centre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CentreDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostCentre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Provincial_Office = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Local_Office = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CostCentre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Engine_Capacity = table.Column<int>(type: "int", nullable: false),
                    Colour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registration_Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Asset_Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Purchase_Year = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleRegDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CARPSatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "vehicleTranfers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    iCarid = table.Column<int>(type: "int", nullable: false),
                    TranferDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    iReasonid = table.Column<int>(type: "int", nullable: false),
                    cFromCostcentre = table.Column<int>(type: "int", nullable: false),
                    cToCostcentre = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicleTranfers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "vehicleTrips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Carid = table.Column<int>(type: "int", nullable: false),
                    openingReading = table.Column<int>(type: "int", nullable: false),
                    closingReading = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicleTrips", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CostCentre");

            migrationBuilder.DropTable(
                name: "Vehicle");

            migrationBuilder.DropTable(
                name: "vehicleTranfers");

            migrationBuilder.DropTable(
                name: "vehicleTrips");
        }
    }
}
