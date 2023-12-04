using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_project_crud_fileupload.Migrations
{
    public partial class booktablescreatedrel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Tags_TagId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_TagId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "TagId",
                table: "Books");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Tags",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Tags");

            migrationBuilder.AddColumn<int>(
                name: "TagId",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_TagId",
                table: "Books",
                column: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Tags_TagId",
                table: "Books",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id");
        }
    }
}
