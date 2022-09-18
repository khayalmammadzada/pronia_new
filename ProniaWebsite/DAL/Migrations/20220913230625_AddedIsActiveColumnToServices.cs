using Microsoft.EntityFrameworkCore.Migrations;

namespace ProniaWebsite.Dal.Migrations
{
    public partial class AddedIsActiveColumnToServices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Services",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Services");
        }
    }
}
