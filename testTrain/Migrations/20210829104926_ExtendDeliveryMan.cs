using Microsoft.EntityFrameworkCore.Migrations;

namespace testTrain.Migrations
{
    public partial class ExtendDeliveryMan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "delieveryDrivers");

            migrationBuilder.AddColumn<float>(
                name: "capacity",
                table: "AspNetUsers",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "carType",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "fullName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nationalID",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "pickUpLocation",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "plateLetters",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "plateNumbers",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_nationalID",
                table: "AspNetUsers",
                column: "nationalID",
                unique: true,
                filter: "[nationalID] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_nationalID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "capacity",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "carType",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "fullName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "nationalID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "pickUpLocation",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "plateLetters",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "plateNumbers",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "delieveryDrivers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    capacity = table.Column<float>(type: "real", nullable: false),
                    carType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nationalID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pickUpLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    plateLetters = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    plateNumbers = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_delieveryDrivers", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_delieveryDrivers_nationalID",
                table: "delieveryDrivers",
                column: "nationalID",
                unique: true,
                filter: "[nationalID] IS NOT NULL");
        }
    }
}
