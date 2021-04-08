using Microsoft.EntityFrameworkCore.Migrations;

namespace EFDataAccessLibrary.Migrations
{
    public partial class ManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_Positions_PositionId",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Person_PositionId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "Person");

            migrationBuilder.CreateTable(
                name: "PositionWorker",
                columns: table => new
                {
                    PositionsId = table.Column<int>(type: "int", nullable: false),
                    WorkerNameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PositionWorker", x => new { x.PositionsId, x.WorkerNameId });
                    table.ForeignKey(
                        name: "FK_PositionWorker_Person_WorkerNameId",
                        column: x => x.WorkerNameId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PositionWorker_Positions_PositionsId",
                        column: x => x.PositionsId,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PositionWorker_WorkerNameId",
                table: "PositionWorker",
                column: "WorkerNameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PositionWorker");

            migrationBuilder.AddColumn<int>(
                name: "PositionId",
                table: "Person",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Person_PositionId",
                table: "Person",
                column: "PositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Positions_PositionId",
                table: "Person",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
