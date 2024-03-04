using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalAgency.Migrations
{
    /// <inheritdoc />
    public partial class Initial4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Cars_carId",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Clients_clientId",
                table: "Transactions");

            migrationBuilder.RenameColumn(
                name: "clientId",
                table: "Transactions",
                newName: "ClientId");

            migrationBuilder.RenameColumn(
                name: "carId",
                table: "Transactions",
                newName: "CarId");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_clientId",
                table: "Transactions",
                newName: "IX_Transactions_ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_carId",
                table: "Transactions",
                newName: "IX_Transactions_CarId");

            migrationBuilder.RenameColumn(
                name: "clientId",
                table: "Clients",
                newName: "ClientId");

            migrationBuilder.RenameColumn(
                name: "carId",
                table: "Cars",
                newName: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Cars_CarId",
                table: "Transactions",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Clients_ClientId",
                table: "Transactions",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Cars_CarId",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Clients_ClientId",
                table: "Transactions");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Transactions",
                newName: "clientId");

            migrationBuilder.RenameColumn(
                name: "CarId",
                table: "Transactions",
                newName: "carId");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_ClientId",
                table: "Transactions",
                newName: "IX_Transactions_clientId");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_CarId",
                table: "Transactions",
                newName: "IX_Transactions_carId");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Clients",
                newName: "clientId");

            migrationBuilder.RenameColumn(
                name: "CarId",
                table: "Cars",
                newName: "carId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Cars_carId",
                table: "Transactions",
                column: "carId",
                principalTable: "Cars",
                principalColumn: "carId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Clients_clientId",
                table: "Transactions",
                column: "clientId",
                principalTable: "Clients",
                principalColumn: "clientId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
