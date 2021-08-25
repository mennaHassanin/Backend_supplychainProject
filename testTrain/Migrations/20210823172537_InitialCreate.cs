using Microsoft.EntityFrameworkCore.Migrations;

namespace testTrain.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "delieveryDrivers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nationalID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    carType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    plateNumbers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    plateLetters = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pickUpLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    capacity = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_delieveryDrivers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "delieveryDrivers");
        }
    }
}
