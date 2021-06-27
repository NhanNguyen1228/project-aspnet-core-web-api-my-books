using Microsoft.EntityFrameworkCore.Migrations;

namespace my_books.Migrations
{
    public partial class editedsomefiledsModelBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateAdd",
                table: "Books",
                newName: "DateAdded");

            migrationBuilder.RenameColumn(
                name: "DataRead",
                table: "Books",
                newName: "DateRead");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateRead",
                table: "Books",
                newName: "DataRead");

            migrationBuilder.RenameColumn(
                name: "DateAdded",
                table: "Books",
                newName: "DateAdd");
        }
    }
}
