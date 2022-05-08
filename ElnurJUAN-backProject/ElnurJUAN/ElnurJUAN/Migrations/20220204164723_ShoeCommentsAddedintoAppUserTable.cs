using Microsoft.EntityFrameworkCore.Migrations;

namespace ElnurJUAN.Migrations
{
    public partial class ShoeCommentsAddedintoAppUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "Shoes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Shoes_AppUserId",
                table: "Shoes",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shoes_AspNetUsers_AppUserId",
                table: "Shoes",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shoes_AspNetUsers_AppUserId",
                table: "Shoes");

            migrationBuilder.DropIndex(
                name: "IX_Shoes_AppUserId",
                table: "Shoes");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Shoes");
        }
    }
}
