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
                values: new object[,]
                {
                    { new Guid("bbdee09c-089b-4d30-bece-44df5923716c"), "Great Company", "Microsoft" },
                    { new Guid("bbdee09c-089b-4d30-bece-44df59237144"), "Not Exists?", "AOL" },
                    { new Guid("5efc910b-2f45-43df-afae-620d40542833"), "Store", "Amazon" },
                    { new Guid("6fb600c1-9011-4fd7-9234-881379716433"), "Music?", "NetEase" },
                    { new Guid("bbdee09c-089b-4d30-bece-44df59237133"), "Brothers", "Jingdong" },
                    { new Guid("5efc910b-2f45-43df-afae-620d40542822"), "- -", "360" },
                    { new Guid("6fb600c1-9011-4fd7-9234-881379716422"), "Blocked", "Youtube" },
                    { new Guid("bbdee09c-089b-4d30-bece-44df59237122"), "Blocked", "Twitter" },
                    { new Guid("5efc910b-2f45-43df-afae-620d40542811"), "From Jiangsu", "Suning" },
                    { new Guid("6fb600c1-9011-4fd7-9234-881379716411"), "Football Club", "AC Milan" },
                    { new Guid("bbdee09c-089b-4d30-bece-44df59237111"), "Wow", "SpaceX" },
                    { new Guid("5efc910b-2f45-43df-afae-620d40542800"), "Photoshop?", "Adobe" },
                    { new Guid("6fb600c1-9011-4fd7-9234-881379716400"), "From Beijing", "Baidu" },
                    { new Guid("bbdee09c-089b-4d30-bece-44df59237100"), "From Shenzhen", "Tencent" },
                    { new Guid("5efc910b-2f45-43df-afae-620d40542853"), "Fubao Company", "Alipapa" },
                    { new Guid("6fb600c1-9011-4fd7-9234-881379716440"), "Don't be evil", "Google" },
                    { new Guid("6fb600c1-9011-4fd7-9234-881379716444"), "Who?", "Yahoo" },
                    { new Guid("5efc910b-2f45-43df-afae-620d40542844"), "Is it a company?", "Firefox" }
                });

            migrationBuilder.InsertData(
                table: "T_Employees",
                columns: new[] { "Id", "CompanyId", "DateOfBirth", "EmployeeNo", "FirstName", "Gender", "LastName" },
                values: new object[,]
                {
                    { new Guid("4b501cb3-d168-4cc0-b375-48fb33f318a4"), new Guid("bbdee09c-089b-4d30-bece-44df5923716c"), new DateTime(1976, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "MSFT231", "Nick", 1, "Carter" },
                    { new Guid("7eaa532c-1be5-472c-a738-94fd26e5fad6"), new Guid("bbdee09c-089b-4d30-bece-44df5923716c"), new DateTime(1981, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "MSFT245", "Vince", 1, "Carter" },
                    { new Guid("72457e73-ea34-4e02-b575-8d384e82a481"), new Guid("6fb600c1-9011-4fd7-9234-881379716440"), new DateTime(1986, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "G003", "Mary", 2, "King" },
                    { new Guid("7644b71d-d74e-43e2-ac32-8cbadd7b1c3a"), new Guid("6fb600c1-9011-4fd7-9234-881379716440"), new DateTime(1977, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "G097", "Kevin", 1, "Richardson" },
                    { new Guid("679dfd33-32e4-4393-b061-f7abb8956f53"), new Guid("5efc910b-2f45-43df-afae-620d40542853"), new DateTime(1967, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "A009", "卡", 2, "里" },
                    { new Guid("1861341e-b42b-410c-ae21-cf11f36fc574"), new Guid("5efc910b-2f45-43df-afae-620d40542853"), new DateTime(1957, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "A404", "Not", 1, "Man" }
                });

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
