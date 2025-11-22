using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EtgAcademy2025.models.database.Migrations
{
    /// <inheritdoc />
    public partial class migration0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TransactionTb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    AccountId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionTb", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TransactionTb_TransactionDate_TransactionId",
                table: "TransactionTb",
                columns: new[] { "TransactionDate", "TransactionId" });

            migrationBuilder.CreateIndex(
                name: "IX_TransactionTb_TransactionId",
                table: "TransactionTb",
                column: "TransactionId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TransactionTb");
        }
    }
}
