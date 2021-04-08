using Microsoft.EntityFrameworkCore.Migrations;

namespace EFDataAccessLibrary.Migrations
{
    public partial class AddedValidation2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Person");

            migrationBuilder.AddColumn<string>(
                name: "Hobbies",
                table: "Person",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hobbies",
                table: "Person");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Person",
                type: "int(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: 0);
        }
    }
}
