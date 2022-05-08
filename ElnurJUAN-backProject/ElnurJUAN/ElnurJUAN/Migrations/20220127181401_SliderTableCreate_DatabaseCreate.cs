using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ElnurJUAN.Migrations
{
    public partial class SliderTableCreate_DatabaseCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    Image = table.Column<string>(maxLength: 200, nullable: true),
                    Title1 = table.Column<string>(maxLength: 65, nullable: true),
                    Title2 = table.Column<string>(maxLength: 65, nullable: true),
                    Desc = table.Column<string>(maxLength: 250, nullable: true),
                    BtnText = table.Column<string>(maxLength: 40, nullable: true),
                    BtnUrl = table.Column<string>(maxLength: 250, nullable: true),
                    Order = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sliders");
        }
    }
}
