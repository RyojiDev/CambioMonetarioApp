using Microsoft.EntityFrameworkCore.Migrations;

namespace CurrencyConverter.Transactions.API.Migrations
{
    public partial class addConvertedCurrency : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "IOF",
                table: "OperationsHistorics",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Spread",
                table: "OperationsHistorics",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IOF",
                table: "OperationsHistorics");

            migrationBuilder.DropColumn(
                name: "Spread",
                table: "OperationsHistorics");
        }
    }
}
