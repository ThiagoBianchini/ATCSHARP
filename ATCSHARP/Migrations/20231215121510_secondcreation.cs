using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATCSHARP.Migrations
{
    public partial class secondcreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "altura",
                table: "Pessoas",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "altura",
                table: "Pessoas");
        }
    }
}
