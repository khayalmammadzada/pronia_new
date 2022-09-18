using Microsoft.EntityFrameworkCore.Migrations;

namespace ProniaWebsite.Dal.Migrations
{
    public partial class SoldCountColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SoldCount",
                table: "Products",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SoldCount",
                table: "Products");
        }
    }
}
