 using Microsoft.EntityFrameworkCore.Migrations;

namespace ElnurJUAN.Migrations
{
    public partial class GenderColumnAddedShoe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Shoes",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Shoes");
        }
    }
}
