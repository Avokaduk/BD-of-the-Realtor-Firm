using Microsoft.EntityFrameworkCore.Migrations;

namespace BD_of_the_Realtor_Firm.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sellers_Contracts_ContractsID1",
                table: "Sellers");

            migrationBuilder.DropIndex(
                name: "IX_Sellers_ContractsID1",
                table: "Sellers");

            migrationBuilder.DropColumn(
                name: "ContractsID1",
                table: "Sellers");

            migrationBuilder.AddColumn<long>(
                name: "ContractsID",
                table: "Buyers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Buyers_ContractsID",
                table: "Buyers",
                column: "ContractsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Buyers_Contracts_ContractsID",
                table: "Buyers",
                column: "ContractsID",
                principalTable: "Contracts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buyers_Contracts_ContractsID",
                table: "Buyers");

            migrationBuilder.DropIndex(
                name: "IX_Buyers_ContractsID",
                table: "Buyers");

            migrationBuilder.DropColumn(
                name: "ContractsID",
                table: "Buyers");

            migrationBuilder.AddColumn<long>(
                name: "ContractsID1",
                table: "Sellers",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sellers_ContractsID1",
                table: "Sellers",
                column: "ContractsID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Sellers_Contracts_ContractsID1",
                table: "Sellers",
                column: "ContractsID1",
                principalTable: "Contracts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
