using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalAgency.Migrations
{
    /// <inheritdoc />
    public partial class Initial7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Clients",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "mobileNumber",
                table: "Clients",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Cars",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "HorsePower",
                table: "Cars",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "mobileNumber",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "HorsePower",
                table: "Cars");
        }
    }
}
