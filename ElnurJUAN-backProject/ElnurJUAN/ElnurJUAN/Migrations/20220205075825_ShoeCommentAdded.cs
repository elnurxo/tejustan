using Microsoft.EntityFrameworkCore.Migrations;

namespace ElnurJUAN.Migrations
{
    public partial class ShoeCommentAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ShoeCommentId",
                table: "ShoeImages",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShoeImages_ShoeCommentId",
                table: "ShoeImages",
                column: "ShoeCommentId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoeImages_ShoeComments_ShoeCommentId",
                table: "ShoeImages",
                column: "ShoeCommentId",
                principalTable: "ShoeComments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoeImages_ShoeComments_ShoeCommentId",
                table: "ShoeImages");

            migrationBuilder.DropIndex(
                name: "IX_ShoeImages_ShoeCommentId",
                table: "ShoeImages");

            migrationBuilder.DropColumn(
                name: "ShoeCommentId",
                table: "ShoeImages");
        }
    }
}
