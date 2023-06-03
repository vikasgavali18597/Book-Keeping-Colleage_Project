using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookKeeper.DataStore.Migrations
{
    /// <inheritdoc />
    public partial class Migration_V2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Amount",
                table: "JournalEntries",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<Guid>(
                name: "CrAccountId",
                table: "JournalEntries",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "DrAccountId",
                table: "JournalEntries",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_JournalEntries_CrAccountId",
                table: "JournalEntries",
                column: "CrAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_JournalEntries_DrAccountId",
                table: "JournalEntries",
                column: "DrAccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_JournalEntries_Accounts_CrAccountId",
                table: "JournalEntries",
                column: "CrAccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_JournalEntries_Accounts_DrAccountId",
                table: "JournalEntries",
                column: "DrAccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JournalEntries_Accounts_CrAccountId",
                table: "JournalEntries");

            migrationBuilder.DropForeignKey(
                name: "FK_JournalEntries_Accounts_DrAccountId",
                table: "JournalEntries");

            migrationBuilder.DropIndex(
                name: "IX_JournalEntries_CrAccountId",
                table: "JournalEntries");

            migrationBuilder.DropIndex(
                name: "IX_JournalEntries_DrAccountId",
                table: "JournalEntries");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "JournalEntries");

            migrationBuilder.DropColumn(
                name: "CrAccountId",
                table: "JournalEntries");

            migrationBuilder.DropColumn(
                name: "DrAccountId",
                table: "JournalEntries");
        }
    }
}
