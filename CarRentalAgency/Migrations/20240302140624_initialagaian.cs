using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalAgency.Migrations
{
    /// <inheritdoc />
    public partial class initialagaian : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Cars_carId1",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Clients_clientId1",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_carId1",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_clientId1",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "carId1",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "clientId1",
                table: "Transactions");

            migrationBuilder.AlterColumn<int>(
                name: "clientId",
                table: "Transactions",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "carId",
                table: "Transactions",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_carId",
                table: "Transactions",
                column: "carId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_clientId",
                table: "Transactions",
                column: "clientId");

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

            migrationBuilder.DropIndex(
                name: "IX_Transactions_carId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_clientId",
                table: "Transactions");

            migrationBuilder.AlterColumn<string>(
                name: "clientId",
                table: "Transactions",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "carId",
                table: "Transactions",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "carId1",
                table: "Transactions",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "clientId1",
                table: "Transactions",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_carId1",
                table: "Transactions",
                column: "carId1");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_clientId1",
                table: "Transactions",
                column: "clientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Cars_carId1",
                table: "Transactions",
                column: "carId1",
                principalTable: "Cars",
                principalColumn: "carId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Clients_clientId1",
                table: "Transactions",
                column: "clientId1",
                principalTable: "Clients",
                principalColumn: "clientId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
