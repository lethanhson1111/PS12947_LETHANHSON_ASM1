using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASM.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MonAns",
                columns: table => new
                {
                    MonAnID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    Gia = table.Column<double>(nullable: false),
                    Phanloai = table.Column<int>(nullable: false),
                    Hinh = table.Column<string>(maxLength: 100, nullable: true),
                    Mota = table.Column<string>(maxLength: 250, nullable: true),
                    Trangthai = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonAns", x => x.MonAnID);
                });

            migrationBuilder.CreateTable(
                name: "Nguoidungs",
                columns: table => new
                {
                    NguoidungID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    DOB = table.Column<DateTime>(nullable: true),
                    Admin = table.Column<bool>(nullable: false),
                    Locked = table.Column<bool>(nullable: false),
                    Password = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nguoidungs", x => x.NguoidungID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MonAns");

            migrationBuilder.DropTable(
                name: "Nguoidungs");
        }
    }
}
