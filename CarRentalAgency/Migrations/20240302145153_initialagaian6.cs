using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalAgency.Migrations
{
    /// <inheritdoc />
    public partial class initialagaian6 : Migration
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

            migrationBuilder.AlterColumn<int>(
                name: "clientId",
                table: "Transactions",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "carId",
                table: "Transactions",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Cars_carId",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Clients_clientId",
                table: "Transactions");

            migrationBuilder.AlterColumn<int>(
                name: "clientId",
                table: "Transactions",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "carId",
                table: "Transactions",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Cars_carId",
                table: "Transactions",
                column: "carId",
                principalTable: "Cars",
                principalColumn: "carId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Clients_clientId",
                table: "Transactions",
                column: "clientId",
                principalTable: "Clients",
                principalColumn: "clientId");
        }
    }
}
