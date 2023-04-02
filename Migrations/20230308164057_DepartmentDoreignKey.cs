using Microsoft.EntityFrameworkCore.Migrations;

namespace SALES_MVC.Migrations
{
    public partial class DepartmentDoreignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DapartmentId",
                table: "Seller",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DapartmentId",
                table: "Seller");
        }
    }
}
