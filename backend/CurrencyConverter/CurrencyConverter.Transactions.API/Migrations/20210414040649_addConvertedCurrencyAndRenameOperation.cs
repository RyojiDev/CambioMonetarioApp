using Microsoft.EntityFrameworkCore.Migrations;

namespace CurrencyConverter.Transactions.API.Migrations
{
    public partial class addConvertedCurrencyAndRenameOperation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OperationsHistorics",
                table: "OperationsHistorics");

            migrationBuilder.RenameTable(
                name: "OperationsHistorics",
                newName: "Operations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Operations",
                table: "Operations",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Currency",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromCoin = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ToCoin = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IOF = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Spread = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Currency");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Operations",
                table: "Operations");

            migrationBuilder.RenameTable(
                name: "Operations",
                newName: "OperationsHistorics");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OperationsHistorics",
                table: "OperationsHistorics",
                column: "Id");
        }
    }
}
