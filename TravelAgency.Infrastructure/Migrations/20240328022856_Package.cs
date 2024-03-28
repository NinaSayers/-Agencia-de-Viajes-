using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelAgency.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Package : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Packages_Agencies_AgencyId",
                table: "Packages");

            migrationBuilder.DropIndex(
                name: "IX_Packages_AgencyId",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "AgencyId",
                table: "Packages");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AgencyId",
                table: "Packages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Packages_AgencyId",
                table: "Packages",
                column: "AgencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Packages_Agencies_AgencyId",
                table: "Packages",
                column: "AgencyId",
                principalTable: "Agencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
