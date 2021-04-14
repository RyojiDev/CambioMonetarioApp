using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CurrencyConverter.Transactions.API.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OperationsHistorics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromCoin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToCoin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperationValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OperationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationsHistorics", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OperationsHistorics");
        }
    }
}
