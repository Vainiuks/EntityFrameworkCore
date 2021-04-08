using Microsoft.EntityFrameworkCore.Migrations;

namespace EFDataAccessLibrary.Migrations
{
    public partial class FixedRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Person_WorkerId",
                table: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Companies_WorkerId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "WorkerId",
                table: "Companies");

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Person",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Person_CompanyId",
                table: "Person",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Companies_CompanyId",
                table: "Person",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_Companies_CompanyId",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Person_CompanyId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Person");

            migrationBuilder.AddColumn<int>(
                name: "WorkerId",
                table: "Companies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Companies_WorkerId",
                table: "Companies",
                column: "WorkerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Person_WorkerId",
                table: "Companies",
                column: "WorkerId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
