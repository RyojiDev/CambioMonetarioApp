using Microsoft.EntityFrameworkCore.Migrations;

namespace CurrencyConverter.Transactions.API.Migrations
{
    public partial class refatoraçãoEntidadeCurrencyConverter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Value",
                table: "Currency",
                newName: "ValueToconvert");

            migrationBuilder.AddColumn<decimal>(
                name: "BaseValue",
                table: "Currency",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalValueConverted",
                table: "Currency",
                type: "decimal(18,2)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BaseValue",
                table: "Currency");

            migrationBuilder.DropColumn(
                name: "TotalValueConverted",
                table: "Currency");

            migrationBuilder.RenameColumn(
                name: "ValueToconvert",
                table: "Currency",
                newName: "Value");
        }
    }
}
