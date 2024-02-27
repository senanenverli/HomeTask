using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace workClass.Migrations
{
    public partial class payonix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "title",
                table: "Sliders",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Sliders",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Sliders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Offer",
                table: "Sliders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "Offer",
                table: "Sliders");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Sliders",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Sliders",
                newName: "id");
        }
    }
}
