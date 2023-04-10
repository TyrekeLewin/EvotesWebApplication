using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvotesWebApplication.Data.Migrations
{
    public partial class AddedCandidateTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Candidates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Parish = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CandidateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnteredDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parishes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CandidatesId = table.Column<int>(type: "int", nullable: false),
                    ParishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParishesCandidateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnteredDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parishes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Parishes_Candidates_CandidatesId",
                        column: x => x.CandidatesId,
                        principalTable: "Candidates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Parishes_CandidatesId",
                table: "Parishes",
                column: "CandidatesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parishes");

            migrationBuilder.DropTable(
                name: "Candidates");
        }
    }
}
