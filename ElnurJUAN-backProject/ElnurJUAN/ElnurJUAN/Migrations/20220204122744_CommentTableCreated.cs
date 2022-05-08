using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ElnurJUAN.Migrations
{
    public partial class CommentTableCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Rate",
                table: "Shoes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ShoeComments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShoeId = table.Column<int>(nullable: false),
                    AppUserId = table.Column<string>(nullable: true),
                    Rate = table.Column<byte>(nullable: false),
                    Text = table.Column<string>(maxLength: 400, nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoeComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoeComments_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShoeComments_Shoes_ShoeId",
                        column: x => x.ShoeId,
                        principalTable: "Shoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShoeComments_AppUserId",
                table: "ShoeComments",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoeComments_ShoeId",
                table: "ShoeComments",
                column: "ShoeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoeComments");

            migrationBuilder.DropColumn(
                name: "Rate",
                table: "Shoes");
        }
    }
}
