using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryData.Migrations
{
    public partial class CorrectedEntityProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BranchHours_LibraryBranches_LibraryBranchId",
                table: "BranchHours");

            migrationBuilder.DropForeignKey(
                name: "FK_LibraryAssets_LibraryBranches_LibraryBranchId",
                table: "LibraryAssets");

            migrationBuilder.DropForeignKey(
                name: "FK_Patrons_LibraryBranches_HomeLibrayBranchId",
                table: "Patrons");

            migrationBuilder.DropIndex(
                name: "IX_Patrons_HomeLibrayBranchId",
                table: "Patrons");

            migrationBuilder.DropIndex(
                name: "IX_LibraryAssets_LibraryBranchId",
                table: "LibraryAssets");

            migrationBuilder.DropIndex(
                name: "IX_BranchHours_LibraryBranchId",
                table: "BranchHours");

            migrationBuilder.DropColumn(
                name: "HomeLibrayBranchId",
                table: "Patrons");

            migrationBuilder.DropColumn(
                name: "LibraryBranchId",
                table: "LibraryAssets");

            migrationBuilder.DropColumn(
                name: "LibraryBranchId",
                table: "BranchHours");

            migrationBuilder.AddColumn<int>(
                name: "HomeLibraryBranchId",
                table: "Patrons",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "LibraryAssets",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "BranchHours",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patrons_HomeLibraryBranchId",
                table: "Patrons",
                column: "HomeLibraryBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_LibraryAssets_LocationId",
                table: "LibraryAssets",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchHours_BranchId",
                table: "BranchHours",
                column: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_BranchHours_LibraryBranches_BranchId",
                table: "BranchHours",
                column: "BranchId",
                principalTable: "LibraryBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LibraryAssets_LibraryBranches_LocationId",
                table: "LibraryAssets",
                column: "LocationId",
                principalTable: "LibraryBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patrons_LibraryBranches_HomeLibraryBranchId",
                table: "Patrons",
                column: "HomeLibraryBranchId",
                principalTable: "LibraryBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BranchHours_LibraryBranches_BranchId",
                table: "BranchHours");

            migrationBuilder.DropForeignKey(
                name: "FK_LibraryAssets_LibraryBranches_LocationId",
                table: "LibraryAssets");

            migrationBuilder.DropForeignKey(
                name: "FK_Patrons_LibraryBranches_HomeLibraryBranchId",
                table: "Patrons");

            migrationBuilder.DropIndex(
                name: "IX_Patrons_HomeLibraryBranchId",
                table: "Patrons");

            migrationBuilder.DropIndex(
                name: "IX_LibraryAssets_LocationId",
                table: "LibraryAssets");

            migrationBuilder.DropIndex(
                name: "IX_BranchHours_BranchId",
                table: "BranchHours");

            migrationBuilder.DropColumn(
                name: "HomeLibraryBranchId",
                table: "Patrons");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "LibraryAssets");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "BranchHours");

            migrationBuilder.AddColumn<int>(
                name: "HomeLibrayBranchId",
                table: "Patrons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LibraryBranchId",
                table: "LibraryAssets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LibraryBranchId",
                table: "BranchHours",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patrons_HomeLibrayBranchId",
                table: "Patrons",
                column: "HomeLibrayBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_LibraryAssets_LibraryBranchId",
                table: "LibraryAssets",
                column: "LibraryBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchHours_LibraryBranchId",
                table: "BranchHours",
                column: "LibraryBranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_BranchHours_LibraryBranches_LibraryBranchId",
                table: "BranchHours",
                column: "LibraryBranchId",
                principalTable: "LibraryBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LibraryAssets_LibraryBranches_LibraryBranchId",
                table: "LibraryAssets",
                column: "LibraryBranchId",
                principalTable: "LibraryBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patrons_LibraryBranches_HomeLibrayBranchId",
                table: "Patrons",
                column: "HomeLibrayBranchId",
                principalTable: "LibraryBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
