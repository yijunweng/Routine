using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Routine.Api.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_Companies",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Introduction = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "T_Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CompanyId = table.Column<Guid>(nullable: false),
                    EmployeeNo = table.Column<string>(maxLength: 100, nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_Employees_T_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "T_Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "T_Companies",
                columns: new[] { "Id", "Introduction", "Name" },
                values: new object[] { new Guid("d68c6076-0134-d879-f7af-71b5de57db98"), "Great Company", "Microsoft" });

            migrationBuilder.InsertData(
                table: "T_Companies",
                columns: new[] { "Id", "Introduction", "Name" },
                values: new object[] { new Guid("a152ab69-1134-d879-f7b9-ea5f99f454c9"), "Dont be evil", "Google" });

            migrationBuilder.InsertData(
                table: "T_Companies",
                columns: new[] { "Id", "Introduction", "Name" },
                values: new object[] { new Guid("faf161f4-a134-d879-f7d6-c654cbd7844a"), "Fubao Company", "Alipapa" });

            migrationBuilder.CreateIndex(
                name: "IX_T_Employees_CompanyId",
                table: "T_Employees",
                column: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_Employees");

            migrationBuilder.DropTable(
                name: "T_Companies");
        }
    }
}
