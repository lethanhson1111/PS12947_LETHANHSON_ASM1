using Microsoft.EntityFrameworkCore.Migrations;

namespace ASM.Migrations
{
    public partial class DBCreat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Khachhangs",
                type: "nvarchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Khachhangs",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Khachhangs");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Khachhangs");
        }
    }
}
