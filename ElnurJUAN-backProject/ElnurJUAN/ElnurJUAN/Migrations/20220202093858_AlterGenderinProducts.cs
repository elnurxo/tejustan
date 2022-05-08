using Microsoft.EntityFrameworkCore.Migrations;

namespace ElnurJUAN.Migrations
{
    public partial class AlterGenderinProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Shoes");

            migrationBuilder.AddColumn<int>(
                name: "GenderId",
                table: "Shoes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Shoes_GenderId",
                table: "Shoes",
                column: "GenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shoes_Genders_GenderId",
                table: "Shoes",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shoes_Genders_GenderId",
                table: "Shoes");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropIndex(
                name: "IX_Shoes_GenderId",
                table: "Shoes");

            migrationBuilder.DropColumn(
                name: "GenderId",
                table: "Shoes");

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Shoes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
