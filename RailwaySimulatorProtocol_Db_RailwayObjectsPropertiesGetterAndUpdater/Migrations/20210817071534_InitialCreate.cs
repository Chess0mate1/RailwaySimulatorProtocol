using Microsoft.EntityFrameworkCore.Migrations;

namespace RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    RearVertexId = table.Column<int>(type: "int", nullable: false),
                    FrontVertexId = table.Column<int>(type: "int", nullable: false),
                    RearRailId = table.Column<int>(type: "int", nullable: true),
                    FrontRailId = table.Column<int>(type: "int", nullable: true),
                    LeftRailId = table.Column<int>(type: "int", nullable: true),
                    RightRailId = table.Column<int>(type: "int", nullable: true),
                    RearSwitchId = table.Column<int>(type: "int", nullable: true),
                    FrontSwitchId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Retarders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    RwNumber = table.Column<int>(type: "int", nullable: false),
                    RailId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Retarders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Semaphores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VertexId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semaphores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Switches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    RwNumber = table.Column<int>(type: "int", nullable: false),
                    RearRailId = table.Column<int>(type: "int", nullable: false),
                    LeftRailId = table.Column<int>(type: "int", nullable: false),
                    RightRailId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Switches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vertices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    X = table.Column<double>(type: "float", nullable: false),
                    Y = table.Column<double>(type: "float", nullable: false),
                    Z = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vertices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wagons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Length = table.Column<double>(type: "float", nullable: false),
                    Base = table.Column<double>(type: "float", nullable: false),
                    CartBase = table.Column<double>(type: "float", nullable: false),
                    WagonModelName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CartName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Destroyed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wagons", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rails");

            migrationBuilder.DropTable(
                name: "Retarders");

            migrationBuilder.DropTable(
                name: "Semaphores");

            migrationBuilder.DropTable(
                name: "Switches");

            migrationBuilder.DropTable(
                name: "Vertices");

            migrationBuilder.DropTable(
                name: "Wagons");
        }
    }
}
