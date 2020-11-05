using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BD_of_the_Realtor_Firm.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Buyers",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Buyers_ID = table.Column<long>(nullable: false),
                    Full_name = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    data = table.Column<DateTime>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Passport_data = table.Column<string>(nullable: true),
                    TypeID = table.Column<long>(nullable: false),
                    Number_rooms = table.Column<int>(nullable: false),
                    Area = table.Column<int>(nullable: false),
                    Bathroom = table.Column<string>(nullable: true),
                    Mark_phone = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Wishes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buyers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(nullable: false),
                    SellersID = table.Column<long>(nullable: false),
                    BuyersID = table.Column<long>(nullable: false),
                    amount = table.Column<int>(nullable: false),
                    Cost = table.Column<int>(nullable: false),
                    TypeID = table.Column<long>(nullable: false),
                    StaffID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sellers",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sellers_ID = table.Column<long>(nullable: false),
                    Full_name = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    data = table.Column<DateTime>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Passport_data = table.Column<string>(nullable: true),
                    TypeID = table.Column<long>(nullable: false),
                    Address_apartament = table.Column<string>(nullable: true),
                    Number_rooms = table.Column<int>(nullable: false),
                    Area = table.Column<int>(nullable: false),
                    Bathroom = table.Column<string>(nullable: true),
                    Mark_phone = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Information = table.Column<string>(nullable: true),
                    ContractsID = table.Column<long>(nullable: true),
                    ContractsID1 = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sellers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Sellers_Contracts_ContractsID",
                        column: x => x.ContractsID,
                        principalTable: "Contracts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sellers_Contracts_ContractsID1",
                        column: x => x.ContractsID1,
                        principalTable: "Contracts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Servis",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Servis_ID = table.Column<long>(nullable: false),
                    Servis_name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    ContractsID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servis", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Servis_Contracts_ContractsID",
                        column: x => x.ContractsID,
                        principalTable: "Contracts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Staff_ID = table.Column<long>(nullable: false),
                    Full_name = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    Adress = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Passport_data = table.Column<string>(nullable: true),
                    PositionID = table.Column<long>(nullable: false),
                    ContractsID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Staff_Contracts_ContractsID",
                        column: x => x.ContractsID,
                        principalTable: "Contracts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Apartments",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type_ID = table.Column<long>(nullable: false),
                    Type_name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    BuyersID = table.Column<long>(nullable: true),
                    SellersID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Apartments_Buyers_BuyersID",
                        column: x => x.BuyersID,
                        principalTable: "Buyers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Apartments_Sellers_SellersID",
                        column: x => x.SellersID,
                        principalTable: "Sellers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Position_ID = table.Column<long>(nullable: false),
                    Position_name = table.Column<string>(nullable: true),
                    Salary = table.Column<int>(nullable: false),
                    Responsibilities = table.Column<string>(nullable: true),
                    Requirements = table.Column<string>(nullable: true),
                    StaffID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Positions_Staff_StaffID",
                        column: x => x.StaffID,
                        principalTable: "Staff",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_BuyersID",
                table: "Apartments",
                column: "BuyersID");

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_SellersID",
                table: "Apartments",
                column: "SellersID");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_StaffID",
                table: "Positions",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_Sellers_ContractsID",
                table: "Sellers",
                column: "ContractsID");

            migrationBuilder.CreateIndex(
                name: "IX_Sellers_ContractsID1",
                table: "Sellers",
                column: "ContractsID1");

            migrationBuilder.CreateIndex(
                name: "IX_Servis_ContractsID",
                table: "Servis",
                column: "ContractsID");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_ContractsID",
                table: "Staff",
                column: "ContractsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Apartments");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Servis");

            migrationBuilder.DropTable(
                name: "Buyers");

            migrationBuilder.DropTable(
                name: "Sellers");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Contracts");
        }
    }
}
